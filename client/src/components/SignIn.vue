<template>
  <div class="container">
    <img src="../assets/IPNLogo.png" class="logo" alt="Logo" />

    <div class="d-flex justify-content-center">
      <div class="user_card">
        <h3 class="heading">Welcome to IPN To Login</h3>
        <br />
        <div>
          <form @submit.prevent="login">
            <div class="input-group mb-3">
              <span class="input-group-text"
                ><i class="fas fa-user fa-2x"></i
              ></span>
              <input
                type="email"
                class="form-control"
                placeholder="Email"
                aria-label="Location"
                aria-describedby="basic-addon1"
                v-model="input.email"
              />
            </div>

            <div class="input-group mb-3">
              <span class="input-group-text"
                ><i class="fas fa-key fa-2x"></i
              ></span>
              <input
                type="password"
                class="form-control"
                placeholder="password"
                aria-label="Location"
                aria-describedby="basic-addon1"
                v-model="input.password"
              />
            </div>

            <div class="Login">
              <button class="btn btn-primary" @click="login()">Login</button>
            </div>
          </form>
        </div>

        <div class="mt-4">
          <div class="d-flex justify-content-center">
            Don't have an account? <a href="/SignUp" class="ml-2">Sign Up</a>
          </div>
          <div class="Forgotpassword">
            <a href="#">Forgot your password?</a>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  data() {
    return {
      input: {
        email: "",
        password: "",
      },
    };
  },
  methods: {
    login() {
      if (this.input.email != "" && this.input.password != "") {
        axios
          .get("https://localhost:44369/user/Authenticate", {
            headers: {
              Authorization: btoa(this.input.email + ":" + this.input.password),
            },
          })
          .then((response) => {
            this.input.response = response.data;
            alert(this.input.response.id);
            if (this.input.response.id != null) {
              this.$router.replace({ name: "CreateArticles" });
            } else {
              alert("Invalid User");
            }
          });

        console.log(this.input.email);
        console.log(this.input.password);
      } else {
        alert("Login with email and Password");
        this.$router.replace({ name: "SignIn" });
      }
    },
  },
};
</script>

<style>
.heading {
  text-align: center;
}
.Login {
  text-align: center;
  margin-top: 10px;
}
.Forgotpassword {
  text-align: center;
}
.user_card {
  height: 350px;
  width: 450px;

  position: relative;
  display: flex;
  justify-content: center;
  flex-direction: column;
  padding: 10px;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
  -webkit-box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2),
    0 6px 20px 0 rgba(0, 0, 0, 0.19);
  -moz-box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2),
    0 6px 20px 0 rgba(0, 0, 0, 0.19);
  border-radius: 5px;
}

.form_container {
  margin-top: 100px;
}

.input-group-text {
  background: #c0392b !important;
  color: white !important;
}
</style>