<template>
  <div class="container">
    <img src="../assets/IPNLogo.png" class="logo" alt="Logo" />
    <div class="d-flex justify-content-center">
      <div class="card">
        <h3 class="heading">Register An Account To Login IPN</h3>
        <div>
          <form @submit.prevent="regiesterAnAccount">
            <div class="input-group mb-3">
              <span class="input-group-text"
                ><i class="fas fa-user fa-2x"></i
              ></span>
              <input
                type="text"
                class="form-control"
                placeholder="FirstName"
                aria-label="FirstName"
                v-model="formData.firstName"
              />
            </div>
            <div class="input-group mb-3">
              <span class="input-group-text"
                ><i class="fas fa-user fa-2x"></i
              ></span>
              <input
                type="text"
                class="form-control"
                placeholder="MiddleName"
                aria-label="MiddleName"
                v-model="formData.middleName"
              />
            </div>
            <div class="input-group mb-3">
              <span class="input-group-text"
                ><i class="fas fa-user fa-2x"></i
              ></span>
              <input
                type="text"
                class="form-control"
                placeholder="LastName"
                aria-label="LastName"
                v-model="formData.lastName"
              />
            </div>

            <div class="input-group mb-3">
              <span class="input-group-text"
                ><i class="fas fa-envelope fa-2x"></i
              ></span>
              <input
                type="email"
                class="form-control"
                placeholder="Email"
                aria-label="Email"
                aria-describedby="basic-addon1"
                v-model="formData.email"
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
                aria-label="password"
                aria-describedby="basic-addon1"
                v-model="formData.password"
              />
            </div>

            <div class="input-group mb-3">
              <span class="input-group-text"
                ><i class="fas fa-mobile fa-2x"></i
              ></span>
              <input
                type="text"
                class="form-control"
                placeholder="Mobile Number"
                aria-label="Location"
                aria-describedby="basic-addon1"
                v-model="formData.mobile"
              />
            </div>
            <div class="Login">
              <button class="btn btn-primary">SignUp</button>
            </div>
          </form>
        </div>
        <div class="mt-4">
          <div class="d-flex justify-content-center">
            Already accont? <a href="/" class="ml-2">Sign</a>
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
      formData: {
        firstName: "",
        middleName: "",
        lastName: "",
        email: "",
        password: "",
        mobile: "",
      },
    };
  },
  methods: {
    regiesterAnAccount() {
      if (
        (this.formData.firstName != "",
        this.formData.lastName != "",
        this.formData.middleName != "",
        this.formData.email != "",
        this.formData.password != "",
        this.formData.mobileNumber != "")
      ) {
        const date = new Date();
        axios
          .post("https://localhost:44369/user", {
            firstName: this.formData.firstName,
            middleName: this.formData.middleName,
            lastName: this.formData.lastName,
            mobile: this.formData.mobile,
            email: this.formData.email,
            passwordHash: this.formData.password,
            profile: "active",
            lastLogin: date,
            registeredAt: date,
          })
          .then((response) => {
            console.log(response);
            this.$router.replace({ name: "SignInWithID", params:{id:response.data.id}});
          })
          .catch((error) => {
            console.log(error);
          });
        this.formData = {};
        this.$router.replace({ name: "SignIn" });
      } else {
        alert("Enter the Items");
      }
    },
  },
};
</script>
<style>
.logo {
  display: block;
  margin-left: auto;
  margin-right: auto;
  margin-bottom: 20px;
  margin-top: 2px;
}
.heading {
  margin-top: 0px;
  text-align: center;
}
.Login {
  text-align: center;
}
.Forgotpassword {
  text-align: center;
  margin-top: 10px;
}
.card {
  margin-top: 0px;
  height: 550px;
  width: 600px;
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
.input-group-text {
  background: #c0392b !important;
  color: white !important;
}
</style>