package com.uninove.point.configuration;

import com.auth0.jwt.JWT;
import com.auth0.jwt.algorithms.Algorithm;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.uninove.point.controller.request.UsuarioLoginRequest;
import com.uninove.point.model.entity.Usuario;
import lombok.AllArgsConstructor;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.AuthenticationException;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.web.authentication.UsernamePasswordAuthenticationFilter;

import javax.servlet.FilterChain;
import javax.servlet.ServletException;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.util.*;

@AllArgsConstructor
public class JWTAuthFilter extends UsernamePasswordAuthenticationFilter {

    private final AuthenticationManager authenticationManager;

    @Override
    public Authentication attemptAuthentication(HttpServletRequest request, HttpServletResponse response) throws AuthenticationException {

        try {
            UsuarioLoginRequest usuario = new ObjectMapper().readValue(request.getInputStream(), UsuarioLoginRequest.class);

            List<GrantedAuthority> authorities = Collections.singletonList(new SimpleGrantedAuthority("USUARIO"));

            return authenticationManager.authenticate(new UsernamePasswordAuthenticationToken(
                    usuario.getEmail(),
                    usuario.getSenha(),
                    authorities
            ));

        } catch (IOException e) {
            throw new RuntimeException("Error: ", e);
        }
    }

    @Override
    protected void successfulAuthentication(HttpServletRequest request, HttpServletResponse response, FilterChain chain, Authentication authResult) throws IOException, ServletException {
        Usuario usuario = (Usuario) authResult.getPrincipal();

        String token = JWT.create()
                        .withClaim("email", usuario.getUsername())
                        .sign(Algorithm.HMAC512(JWTProperties.TOKEN_SECRET));

        Cookie cookie = new Cookie("token", token);
        cookie.setPath("/");
        cookie.setHttpOnly(true);
        cookie.setMaxAge(60 * 600000);
        response.addCookie(cookie);

        super.successfulAuthentication(request, response, chain, authResult);
    }
}
