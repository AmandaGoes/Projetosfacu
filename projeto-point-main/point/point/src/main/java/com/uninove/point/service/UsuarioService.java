package com.uninove.point.service;

import com.auth0.jwt.JWT;
import com.auth0.jwt.algorithms.Algorithm;
import com.auth0.jwt.interfaces.DecodedJWT;
import com.uninove.point.configuration.JWTProperties;
import com.uninove.point.model.entity.Usuario;
import com.uninove.point.model.repository.UsuarioRepository;
import lombok.AllArgsConstructor;
import lombok.NoArgsConstructor;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Service;

import java.util.Optional;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

@Service
public class UsuarioService implements UserDetailsService {

    private final static String USER_NOT_FOUND_MESSAGE = "Usuario com o email %s não foi encontrado.";

    private final UsuarioRepository usuarioRepository;
    private final BCryptPasswordEncoder bCryptPasswordEncoder;

    private void inscreverUsuario(Usuario usuario){
        boolean usuarioExists = usuarioRepository.findByEmail(usuario.getEmail()).isPresent();

        if(usuarioExists){
            throw new IllegalStateException("Email já cadastrado.");
        }

        String senhaCript = bCryptPasswordEncoder.encode(usuario.getPassword());

        usuario.setSenha(senhaCript);

        usuarioRepository.save(usuario);
    }

    private boolean emailRegexValidator(String email){

        //regex para email
        String regex = "^[\\w!#$%&amp;'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&amp;'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
        Pattern pattern = Pattern.compile(regex);
        Matcher matcher = pattern.matcher(email);
        return matcher.matches();
    }

    public Usuario validationTokenUser(String token){

        /*TOKEN VERIFICACAO*/
        DecodedJWT decodedJWT = JWT.require(Algorithm.HMAC512(JWTProperties.TOKEN_SECRET))
                .build()
                .verify(token);

        String email = decodedJWT.getClaim("email").asString();

        Usuario usuario = null;

        try{
            usuario = loadUserByUsername(email);

        } catch (Exception err){
            new IllegalStateException("Não foi possível encontrar o usuário da sessão!");
        }
        /*TOKEN VERIFICACAO*/

        return usuario;
    }

    public UsuarioService(UsuarioRepository usuarioRepository, BCryptPasswordEncoder bCryptPasswordEncoder) {
        this.usuarioRepository = usuarioRepository;
        this.bCryptPasswordEncoder = bCryptPasswordEncoder;
    }

    @Override
    public Usuario loadUserByUsername(String email) throws UsernameNotFoundException {
        return usuarioRepository.findByEmail(email)
                .orElseThrow(() ->
                        new UsernameNotFoundException(String.format(USER_NOT_FOUND_MESSAGE, email)));
    }

    public String cadastrar(Usuario usuario){
        boolean validacaoEmail = emailRegexValidator(usuario.getEmail());

        if(!validacaoEmail){
            throw new IllegalStateException("Email em formato inválido.");

        } else {

            if(usuario.getSenha() != null){

                inscreverUsuario(new Usuario(
                        usuario.getNome(),
                        usuario.getIdade(),
                        usuario.getEmail(),
                        usuario.getSenha()
                ));

                return "Usuário cadastrado com sucesso!";

            } else {
                throw new IllegalStateException("Dados de usuário inválidos!");
            }
        }
    }

    public Optional<Usuario> findUsuario(Long id){
        return Optional.of(usuarioRepository.getById(id));
    }

    public void alterarSenha(Usuario usuario){
        Usuario usuarioPasswordChange = usuarioRepository.getById(usuario.getId());
        usuarioPasswordChange.setSenha(bCryptPasswordEncoder.encode(usuario.getSenha()));
        usuarioRepository.save(usuarioPasswordChange);
    }

    public void alterarDados(Usuario usuario, Usuario usuarioRequest){
        usuario.setNome(usuarioRequest.getNome());
        usuario.setIdade(usuarioRequest.getIdade());
        usuario.setEmail(usuarioRequest.getEmail());

        usuarioRepository.save(usuario);
    }

    public void deletarUsuario(Usuario usuario){
        usuarioRepository.deleteById(usuario.getId());
    }
}
