<template>
    <header>
        <nav>
            <ul id="list-links">
                <li class="item-link">
                    <div>
                        <button type="button">
                            <router-link class="link-route" to="/">
                                Início
                            </router-link>
                        </button>
                    </div>
                </li>
                <li class="item-link">
                    <div>
                        <button type="button">
                            <router-link class="link-route" to="/">Dashboard</router-link>
                        </button>
                    </div>
                </li>
                <li class="item-link">
                    <div>
                        <button type="button">
                            <router-link class="link-route" to="/map">Mapa</router-link>
                        </button>
                    </div>
                </li>
                <li class="item-link">
                    <div class="dropdown-center">
                        <button class="dropdown-toggle link-route" type="button" data-bs-toggle="dropdown" aria-expanded="false">
                            Veículos
                        </button>
                        <ul class="dropdown-menu">
                            <li><router-link class="dropdown-item link-dropdown" to="/vehicle/all">Visualizar</router-link>
                            </li>
                            <li><router-link class="dropdown-item link-dropdown" to="/vehicle/register">Cadastrar</router-link></li>
                        </ul>
                    </div>
                </li>
                <li class="item-link">
                    <div class="dropdown-center">
                        <button class="dropdown-toggle link-route" type="button" data-bs-toggle="dropdown" aria-expanded="false">
                            Motoristas
                        </button>
                        <ul class="dropdown-menu">
                            <li><router-link class="dropdown-item link-dropdown" to="/driver/all">
                                    Visualizar
                                </router-link>
                            </li>
                            <li><router-link class="dropdown-item link-dropdown" to="/driver/register">
                                    Cadastrar
                                </router-link>
                            </li>
                        </ul>
                    </div>
                </li>
            </ul>
        </nav>
    </header>
</template>

<style scoped>
header {
    width: 100vw;
    height: 10vh;
    display: flex;
    justify-content: center;
    align-items: center;
}

nav {
    width: 60%;
    height: 80%;
}

button {
    background-color: transparent;
    border: none;
    height: 100%;
    width: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    text-decoration: none;
    text-decoration-line: none;
}

.item-link {
    list-style-type: none;
    height: 100%;
    width: 25%;
}

.link-route {
    font-size: 20px;
    text-decoration: none;
    color: #FFFBEB;
}

.link-route:hover {
    color: #dadada;
}

.link-dropdown {
    color: #414141;
}

#list-links {
    width: 100%;
    height: 100%;
    display: flex;
}
</style>