package com.app.dto;

import com.fasterxml.jackson.databind.util.ClassUtil.Ctor;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import lombok.ToString;

@NoArgsConstructor
@AllArgsConstructor
//@Getter
//@Setter
//@ToString
public class LoginRequestDto {
	// data members MUST MATCH with JSON prop names
	private String email;
	private String password;
	public LoginRequestDto() {
		// TODO Auto-generated constructor stub
	}
	public LoginRequestDto(String email, String password) {
		super();
		this.email = email;
		this.password = password;
	}
	public String getEmail() {
		return email;
	}
	public String getPassword() {
		return password;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	@Override
	public String toString() {
		return "LoginRequestDto [email=" + email + ", password=" + password + "]";
	}
	
	
	
}
