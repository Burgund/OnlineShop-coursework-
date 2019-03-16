const app = document.getElementById('root')
const container = document.createElement('div')

app.appendChild(container)

var request = new XMLHttpRequest()
request.open('GET', 'http://localhost:52269/api/products/5', true)
request.onload = function() {
  var data = JSON.parse(this.response)
  if (request.status >= 200 && request.status < 400) {
    data.forEach(product => {
      const card = document.createElement('div')
      const h1 = document.createElement('h1')
      h1.textContent = product.name

      const p = document.createElement('p')
      p.textContent = product.price

      container.appendChild(card)
      card.appendChild(h1)
      card.appendChild(p)
      //test
      console.log(product);
    })
  } else {
    const errorMessage = document.createElement('marquee')
    errorMessage.textContent = `Ooops, something went wrong!`
    app.appendChild(errorMessage)
  }
}

request.send()
