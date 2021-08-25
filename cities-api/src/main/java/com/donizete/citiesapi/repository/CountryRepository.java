package com.donizete.citiesapi.repository;

import com.donizete.citiesapi.Country.Country;
import org.springframework.data.jpa.repository.JpaRepository;

public interface CountryRepository extends JpaRepository<Country, Long> {
}
