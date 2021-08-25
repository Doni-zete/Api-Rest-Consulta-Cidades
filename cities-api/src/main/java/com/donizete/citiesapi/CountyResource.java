package com.donizete.citiesapi;


import com.donizete.citiesapi.Country.Country;
import com.donizete.citiesapi.countries.Country;
import com.donizete.citiesapi.repository.CountryRepository;
import java.util.List;
import antlr.ASTNULLType;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;


@RestController
@RequestMapping("/countries")
public class CountyResource {

    private CountryRepository repository;
        @GetMapping
       public List<Country>countries(){

       }

    }
