<template>
  <div class="container">
    <img src="../assets/IPNLogo.png" class="logo" alt="Logo" />
    <div class="d-flex justify-content-center">
      <div class="card">
        <div>
          <h3 class="heading">Register An Account To Login To IPN</h3>
          <br />

          <form>
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
              />
            </div>

            <div class="input-group mb-3">
              <span class="input-group-text"
                ><i class="fas fa-key fa-2x"></i
              ></span>
              <input
                type="password"
                class="form-control"
                placeholder="Confirm password"
                aria-label="Location"
                aria-describedby="basic-addon1"
              />
            </div>

            <div class="input-group mb-3">
              <span class="input-group-text"
                ><i class="fas fa-map-marker fa-2x"></i
              ></span>
              <input
                type="password"
                class="form-control"
                placeholder="Location"
                aria-label="Location"
                aria-describedby="basic-addon1"
              />
            </div>

            <div class="input-group mb-3">
              <span class="input-group-text"
                ><i class="fas fa-calendar-minus fa-2x"></i
              ></span>
              <input
                type="date"
                class="form-control"
                aria-label="Location"
                aria-describedby="basic-addon1"
              />
            </div>

            <div class="input-group mb-3">
              <span class="input-group-text"
                ><i class="fas fa-mobile fa-2x"></i
              ></span>
              <input
                type="number"
                class="form-control"
                placeholder="Mobile Number"
                aria-label="Location"
                aria-describedby="basic-addon1"
              />
            </div>

            <div class="Login">
              <button type="button" class="btn btn-primary">SignUp</button>
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
export default {};
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