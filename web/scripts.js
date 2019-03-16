const app = document.getElementById('root')
const container = document.createElement('div')

const name0 = document.getElementById('name0')
const price0 = document.getElementById('price0')
const name1 = document.getElementById('name1')
const price1 = document.getElementById('price1')
const name2 = document.getElementById('name2')
const price2 = document.getElementById('price2')
const name3 = document.getElementById('name3')
const price3 = document.getElementById('price3')
const name4 = document.getElementById('name4')
const price4 = document.getElementById('price4')

app.appendChild(container)

var index = 0
var secondIndex = 0

var request = new XMLHttpRequest()
request.open('GET', 'http://localhost:52269/api/products', true)
request.onload = function() {
  var data = JSON.parse(this.response)
  if (request.status >= 200 && request.status < 400) {
    data.forEach(product => {
        index = index + 1
        if(index == 1)
        {
            name0.textContent = product[0]
            price0.textContent = product[1]
            console.log(product)
        }
        if(index == 2)
        {
          name1.textContent = product[0]
          price1.textContent = product[1]
          console.log(product)
        }
        if(index == 3)
        {
          name2.textContent = product[0]
          price2.textContent = product[1]
          console.log(product)
        }
        if(index == 4)
        {
          name3.textContent = product[0]
          price3.textContent = product[1]
          console.log(product)
        }
        if(index == 5)
        {
          name4.textContent = product[0]
          price4.textContent = product[1]
          console.log(product)
        }
    })
  } else {
    name0.textContent = "Ooops!"
    price0.textContent = ~"Something went wrong!"
  }
}
request.send()
