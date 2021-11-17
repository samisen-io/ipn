<template>
  <div class="container h-100">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="d-flex justify-content-center h-100">
      <div class="card">
        <div class="d-flex justify-content-center">
          <div class="brand_logo_container">
            <img src="../assets/user.png" class="brand_logo" alt="Logo" />
          </div>
        </div>
        <br />
         <br />
        <div class="details">
          <h3 class="heading"> Regiester An Account</h3>
        
          <form>
            <div class="input-group mb-3">
              <span class="input-group-text"><i class="fas fa-user"></i></span>
              <input
                type="email"
                class="form-control"
                placeholder="Email"
                aria-label="Location"
                aria-describedby="basic-addon1"
              />
            </div>

            <div class="input-group mb-3">
              <span class="input-group-text"><i class="fas fa-key"></i></span>
              <input
                type="password"
                class="form-control"
                placeholder="password"
                aria-label="Location"
                aria-describedby="basic-addon1"
              />
            </div>

            <div class="input-group mb-3">
              <span class="input-group-text"><i class="fas fa-key"></i></span>
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
                ><i class="fas fa-map-marker"></i
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
                ><i class="fas fa-calendar-minus"></i
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
                ><i class="fas fa-mobile"></i
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
              <button type="button" class="btn btn-primary">Login</button>
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
.details{
     margin-top: 70px;
}
.heading {
  text-align: center;
  margin-bottom: 20px;
}
.Login {
  text-align: center;
}
.Forgotpassword {
  text-align: center;
  margin-top: 10px;
}
.card {
  height: 600px;
  width: 600px;
  margin-top: auto;
  margin-bottom: auto;
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
.brand_logo_container {
  position: absolute;
  height: 170px;
  width: 170px;
  top: -75px;
  border-radius: 50%;
  background: #60a3bc;
  padding: 10px;
  text-align: center;
}
.brand_logo {
  height: 150px;
  width: 150px;
  border-radius: 50%;
  border: 2px solid white;
}
.form_container {
  margin-top: 100px;
}

.input-group-text {
  background: #c0392b !important;
  color: white !important;
  width: 10%;
}
</style>