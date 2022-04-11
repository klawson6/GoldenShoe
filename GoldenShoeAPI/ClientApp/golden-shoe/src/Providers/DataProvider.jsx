export default {
    getShoes: async function () {
        return new Promise((resolve, reject) => {
            fetch(`https://localhost:44313/api/shoes`, {
                method: 'GET'
            })
                .then(response => {
                    if(!response.ok) this.handleErrorResponse(response, resolve, reject)
                    return response.json();
                })
                .then(body => {
                    resolve(body);
                })
        })
    },
    getShoe: function (id) {
        return new Promise((resolve, reject) => {
            console.log(`https://localhost:44313/api/shoes/${id}`)
            fetch(`https://localhost:44313/api/shoes/${id}`, {
                method: 'GET'
            })
                .then(response => {
                    if(!response.ok) this.handleErrorResponse(response, resolve, reject)
                    return response.json();
                })
                .then(body => {
                    resolve(body);
                })
        })
    },
    handleErrorResponse: function(response, resolve, reject){
        reject(response.status);
    }
}