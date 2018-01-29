from flask import Flask, request
app = Flask(__name__)

@app.route("/") #picks what endpoint calls what function
def hello():
    return app.send_static_file('index.html')
@app.route("/api/growl", methods=["POST"])
def receive_growl():
    print(request.form)
    return "Success!"

if __name__ == "__main__":
    app.run(debug=True)