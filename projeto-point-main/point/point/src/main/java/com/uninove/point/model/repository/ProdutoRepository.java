package com.uninove.point.model.repository;

import com.uninove.point.model.entity.Produto;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface ProdutoRepository extends JpaRepository<Produto, Long> {

    @Query("SELECT d FROM Produto d WHERE usuario_id = ?1")
    List<Produto> produtoList(Long id);

}
