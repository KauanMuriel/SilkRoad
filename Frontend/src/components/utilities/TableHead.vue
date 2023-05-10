<template>
    <thead>
        <tr>
            <slot name="th-cols">
                <th v-for="name in colNames" scope="col"> {{ name }}</th>
                <th>Actions</th>
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
            let names = [];
            for (let key in item) names.push(key);

            var formatedNames = this.putFirstLetterUpperCase(names);
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
        }
    }
}
</script>