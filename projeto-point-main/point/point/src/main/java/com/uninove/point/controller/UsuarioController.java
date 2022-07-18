package com.uninove.point.controller;

import com.uninove.point.model.entity.Usuario;
import com.uninove.point.service.UsuarioService;
import com.uninove.point.controller.request.MessageRequest;
import lombok.AllArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.Optional;

@RestController
@AllArgsConstructor
@RequestMapping("/usuario")
public class UsuarioController {

    private UsuarioService usuarioService;

    @PostMapping("/cadastrar")
    public ResponseEntity<MessageRequest> cadastrar(@RequestBody Usuario usuario){
        return new ResponseEntity(new MessageRequest(usuarioService.cadastrar(usuario)), HttpStatus.CREATED);
    }

    @PutMapping("/auth/alterar-dados")
    public ResponseEntity<MessageRequest> alterarDados(@CookieValue("token") String token){

        Usuario usuarioRequest = usuarioService.validationTokenUser(token);

        Optional<Usuario> usuario = usuarioService.findUsuario(usuarioRequest.getId());

        if(usuario.isPresent()){
            usuarioService.alterarDados(usuario.get(), usuarioRequest);
            return new ResponseEntity(new MessageRequest("Dados de usuário alterados com sucesso!"), HttpStatus.ACCEPTED);

        } else {
            throw new IllegalStateException("Dados de usuário inválidos!");
        }
    }

    @PutMapping("/auth/alterar-senha")
    public ResponseEntity<MessageRequest> alterarSenha(@CookieValue("token") String token){
        Usuario usuario = usuarioService.validationTokenUser(token);

        usuarioService.alterarSenha(usuario);
        return new ResponseEntity(new MessageRequest("Senha de usuário alterada com sucesso!"), HttpStatus.ACCEPTED);
    }

    @DeleteMapping("/auth/deletar")
    public ResponseEntity<MessageRequest> deletarUsuario(@CookieValue("token") String token){
        Usuario usuario = usuarioService.validationTokenUser(token);

        usuarioService.deletarUsuario(usuario);
        return new ResponseEntity(new MessageRequest("Usuário deletado com sucesso!"), HttpStatus.ACCEPTED);
    }
}
