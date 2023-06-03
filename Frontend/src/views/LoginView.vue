<template>
    <div id="login-behind">
        <div id="login-card">
        <div class="row" id="top-row">
            <label for="input-login">Login</label>
            <input type="text" id="input-login" v-model="loginTyped">
        </div>
        <div class="row">
            <label for="input-password">Senha</label>
            <input type="password" name="input-password" id="input-password" v-model="passwordTyped">
        </div>
        <button @click="authenticateUser()" id="btn-login" :disabled="blockAttempts">Entrar</button>
        <div id="login-advise" v-if="lastAttemptFailed">
            <p>Usuário ou senha incorretos. Por favor, tente novamente!</p>
        </div>
        <div id="login-advise" v-if="blockAttempts">
            <p>Muitas tentativas de login incorretas. Tente novamente mais tarde!</p>
        </div>
    </div>
</div></template>

<script>
export default {
    data() {
        return {
            userName: 'Admin',
            password: 'admin123',
            loginTyped: null,
            passwordTyped: null,
            attemptsFailed: 0,
            blockAttempts: false,
            lastAttemptFailed: false
        }
    },
    methods: {
        authenticateUser() {
            if (this.loginTyped === this.userName && this.passwordTyped === this.password) {
                this.$emit("authentication");
            }
            else
            {
                this.attemptsFailed++;
                this.checkAttempts();
            }
        },
        checkAttempts() {
            if (this.attemptsFailed === 3) {
                this.lastAttemptFailed = false;
                this.blockAttempts = true;
            }
            else
                this.lastAttemptFailed = true;
        }
    },
    emits: ['authentication']
}
</script>

<style scoped>
#login-behind {
    position: absolute;
    width: 100vw;
    height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
    background-color: #2f3e46;
    z-index: 999;
}

#login-card {
    display: flex;
    align-items: center;
    flex-direction: column;
    width: 40%;
    height: 70%;
    background-color: #f4f1de;
    border-radius: 12px;
}

.row {
    width: 60%;
    margin-bottom: 8%;
    display: flex;
    flex-direction: column;
}

#btn-login {
    width: 30%;
    height: 8%;
    background-color: #2f3e46;
    border-radius: 8px;
    color: #f4f1de;
}

#btn-login:hover {
    background-color: #405763;
}

#top-row {
    margin-top: 15%;
}

#login-advise {
    margin-top: 5%;
}

#login-advise p {
    color: rgb(186, 10, 10);
}

#btn-login:disabled {
    cursor: not-allowed;
}
</style>