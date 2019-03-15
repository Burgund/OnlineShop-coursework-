package ccs;

public class Currency {
	private String currencyCode;
	private String country;
	private double conversionRateWithPLN;
	
	public Currency() {}
	
	public Currency(String currencyCode, String country, double conversionRateWithPLN) {
		setCurrencyCode(currencyCode);
		setCountry(country);
		setConversionRateWithPLN(conversionRateWithPLN);
	}
	
	public void setCurrencyCode(String currencyCode) {
		this.currencyCode = currencyCode;
	}
	
	public void setCountry(String country) {
		this.country = country;
	}
	
	public void setConversionRateWithPLN(double conversionRateWithPLN) {
		this.conversionRateWithPLN = conversionRateWithPLN;
	}
	
	public String getCurrencyCode() {
		return currencyCode;
	}
	
	public String getCountry() {
		return country;
	}
	
	public double getConversionRateWithPLN() {
		return conversionRateWithPLN;
	}
}