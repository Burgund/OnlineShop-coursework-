function sendOrder() {
  var order = new XMLHttpRequest()
  order.open("POST", 'http://localhost:52269/api/Orders', true)
  order.setRequestHeader("Content-Type", "application/x-www-form-urlencoded")
  order.onreadystatechange = function() {
      if (this.readyState === XMLHttpRequest.DONE && this.status === 200) {
          console.log(this.status)
          console.log(this.response)
      }
  }
  order.send(JSON.stringify({ "value": "test" }))
}
