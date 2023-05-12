<template>
    <thead>
        <tr>
            <slot name="th-cols">
                <th v-for="name in colNames" scope="col"> {{ name }}</th>
                <th v-if="colNames.length">Actions</th>
            </slot>
        </tr>
    </thead>
</template>

<script>
export default {
    props: ['collection'],
    computed: {
        colNames() {
            const item = this.collection[0];
            let formatedNames = [];

            if (item != null) {
                let names = [];
                for (let key in item) names.push(key);
    
                formatedNames = this.putFirstLetterUpperCase(names);
    
                //this.putIdInFirsPosition(formatedNames);
            }
            return formatedNames;
        }
    },
    methods: {
        putFirstLetterUpperCase(words) {
            let wordsUpper = [];

            for (let word of words) {
                let wordTotalLower = word.toLowerCase();

                let firstLetter = wordTotalLower[0].toUpperCase();

                wordTotalLower = wordTotalLower.slice(1);

                let finalWord = firstLetter.concat(wordTotalLower);

                wordsUpper.push(finalWord);
            }
            return wordsUpper;
        },
        // putIdInFirsPosition(names) {
        //     let idIndex = this.findIdIndexInsideColNames(names);
            
        //     if (idIndex != null && idIndex != 0) {    
        //         let auxColumn = names[0];
        //         names[0] = 'Id';
        //         names[idIndex] = auxColumn;
        //     }
        // },
        // findIdIndexInsideColNames(names) {
        //     let idIndex = null;

        //     for (let i = 0; i < names.length; i++) {
        //         if (names[i] == 'Id') {
        //             idIndex = i;
        //         }
        //     }
        //     return idIndex;
        // }
    }
}
</script>