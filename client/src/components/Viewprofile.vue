<template>
  <div class="container">
    <h1 class="profileHeading">ProfileDetails</h1>
    <div class="viewProfilecard">
      <div class="buttonInProfile">
      <button type="button" class="btn btn-info">Edit</button>
      </div>
      <div class="row">
        <div class="col">
          <img src="../assets/user.png" class="img" alt="UserLogo" />
        </div>
        <div class="col">
          <br />
          <br />
          <br />
          <br />
          <div class="input-group mb-3">
            <span class="input-group-text" style="width: 20%" id="basic-addon1"
              >Name</span
            >
            <input
              type="text"
              class="form-control"
              placeholder="Username"
              aria-label="Username"
              aria-describedby="basic-addon1"
              v-model="data.Name"
            />
          </div>
          <div class="input-group mb-3">
            <span class="input-group-text" style="width: 20%" id="basic-addon1"
              >Location</span
            >
            <input
              type="text"
              class="form-control"
              placeholder="Location"
              aria-label="Location"
              aria-describedby="basic-addon1"
              v-model="data.Location"
            />
          </div>

          <div class="input-group mb-3">
            <span class="input-group-text" style="width: 20%" id="basic-addon1"
              >DateOfBirth</span
            >
            <input
              type="date"
              class="form-control"
              aria-label="DateOfBirth"
              aria-describedby="basic-addon1"
              v-model="data.DateOfBirth"
            />
          </div>
          <div class="input-group mb-3">
            <span class="input-group-text" style="width: 20%" id="InputTag"
              >MobileNumber</span
            >
            <input
              type="number"
              class="form-control"
              placeholder="MobileNumber"
              aria-label="MobileNumber"
              aria-describedby="basic-addon1"
              v-model="data.MobileNumber"
            />
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      data: {
        Name: "Venkat",
        Location: "Chirala",
        DateOfBirth: "1997-08-26",
        MobileNumber: "9398385910",
      },
    };
  },
};
</script>

<style>
.InputTag {
  width: 100%;
}
.forForm {
  margin-bottom: 50px;
}
.buttonInProfile{
  text-align: right;
}
.profileHeading {
  margin-top: 20px;
  text-align: center;
}
.border {
  margin-top: 20px;
  margin-bottom: 20px;
  border-style: solid;
}
.img {
  height: 400px;
  width: 400px;
}
.deatils {
  margin-bottom: 20px;
}

.viewProfilecard {
  border: 3px solid red;
  border-radius: 25px;
  height: 500px;
  width: 100%;
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
}
</style>