class TimeMap {
    map: { [key: string]: [number, string][] } = {};

    constructor() {
        this.map = {};
    }

    set(key: string, value: string, timestamp: number): void {
        if (key in this.map) this.map[key].push([timestamp, value]);
        else this.map[key] = [[timestamp, value]];
    }

    get(key: string, timestamp: number): string {
        if (key in this.map === false) return '';

        const array = this.map[key];

        let left = 0, right = array.length - 1;
        let res = "";

        while (left <= right) {
            const idx = Math.round((left + right) / 2);
            const [time, val] = array[idx];
            if (time === timestamp) return val;
            if (time > timestamp) right = idx - 1;
            else {
                res = val;
                left = idx + 1;
            }
        }

        return res ?? '';
    }
}