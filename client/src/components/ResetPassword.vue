<template>
  <div>
    <div class="container">
      <h1 class="forgotHeading">ResetPassword</h1>
      <div class="d-flex justify-content-center">
        <div class="ResetPassword">
          <div class="input-group mb-3">
            <span class="input-group-text"
              ><i class="fas fa-key fa-2x"></i
            ></span>
            <input
              v-bind:type="[showPassword ? 'text' : 'password']"
              class="form-control"
              placeholder="Password"
            />

            <span
              class="input-group-text"
              @click="showPassword = !showPassword"
            >
              <i
                class="fa"
                :class="[showPassword ? 'fa-eye' : 'fa-eye-slash']"
                aria-hidden="true"
              ></i>
            </span>
          </div>
          <div class="input-group mb-3">
            <span class="input-group-text"
              ><i class="fas fa-key fa-2x"></i
            ></span>
            <input
              v-bind:type="[showPasswordConfirm ? 'text' : 'password']"
              class="form-control"
              placeholder="ConfirmPassword"
            />

            <span
              class="input-group-text"
              @click="showPasswordConfirm = !showPasswordConfirm"
            >
              <i
                class="fa"
                :class="[showPasswordConfirm ? 'fa-eye' : 'fa-eye-slash']"
                aria-hidden="true"
              ></i>
            </span>
          </div>
          <div class="submitbutton">
            <button type="button" class="btn btn-primary">Reset</button>
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
      showPassword: false,
      showPasswordConfirm: false,
    };
  },
};
</script>

<style>
.ResetPassword {
  margin-top: 100px;
  height: 200px;
  width: 40%;
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
.submitbutton {
  text-align: right;
}
.forgotHeading {
  text-align: center;
}
</style>