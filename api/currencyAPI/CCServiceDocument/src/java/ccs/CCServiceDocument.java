package ccs;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.soap.SOAPBinding;
import javax.jws.soap.SOAPBinding.Style;
import java.util.*;

@WebService
@SOAPBinding(style = Style.DOCUMENT)
public class CCServiceDocument {
	private HashMap<String, Currency> currencies = new HashMap<String, Currency>();
	
	public CCServiceDocument(){
		currencies.put("PLN", new Currency("PLN", "Poland", 1));
		currencies.put("USD", new Currency("USD", "United States", 3.28));
		currencies.put("EUR", new Currency("EUR", "European Union", 4.32));
	}
	
	@WebMethod
	public double getConversionRate(Currency from, Currency to){
		return from.getConversionRateWithPLN() / to.getConversionRateWithPLN();
	}
	
	@WebMethod
	public List<Currency> getListOfCurrencies() {
		List<Currency> list = new ArrayList<Currency>(currencies.values());
		return list;
	}
}