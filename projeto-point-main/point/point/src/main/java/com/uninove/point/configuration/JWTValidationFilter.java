package com.uninove.point.configuration;

import com.auth0.jwt.JWT;
import com.auth0.jwt.algorithms.Algorithm;
import com.auth0.jwt.exceptions.JWTVerificationException;
import com.auth0.jwt.interfaces.DecodedJWT;
import org.springframework.http.HttpStatus;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.web.authentication.www.BasicAuthenticationFilter;
import org.springframework.web.util.WebUtils;

import javax.servlet.FilterChain;
import javax.servlet.ServletException;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.util.Collections;
import java.util.List;

public class JWTValidationFilter extends BasicAuthenticationFilter {

    public JWTValidationFilter(AuthenticationManager authenticationManager) {
        super(authenticationManager);
    }

    @Override
    protected void doFilterInternal(HttpServletRequest request, HttpServletResponse response, FilterChain chain) throws IOException, ServletException, ServletException {

        Cookie token = WebUtils.getCookie(request, "token");

        if (token == null) {
            chain.doFilter(request, response);
            return;
        }

        try {

            String jwt = token.getValue();

            DecodedJWT decodedJwt = JWT.require(Algorithm.HMAC512(JWTProperties.TOKEN_SECRET))
                    .build()
                    .verify(jwt);

            String login = decodedJwt.getClaim("email").asString();

            List<GrantedAuthority> authorities = Collections.singletonList(new SimpleGrantedAuthority("USUARIO"));

            UsernamePasswordAuthenticationToken authentication =
                    new UsernamePasswordAuthenticationToken(login, null, authorities);

            SecurityContextHolder.getContext().setAuthentication(authentication);

            chain.doFilter(request, response);

        } catch (JWTVerificationException ex) {
            response.sendError(HttpStatus.UNAUTHORIZED.value());
            return;
        }
    }

}
