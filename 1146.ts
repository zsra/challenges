class SnapshotArray {

    snapCount: number
    snapArray: any

    constructor(length: number) {
        this.snapCount = 0
        this.snapArray = []
        
        for (let i = 0; i < length; i++) {
            this.snapArray.push([])
        }
    }

    set(index: number, val: number): void {
        this.snapArray[index].push({ s: this.snapCount, val })
    }

    snap(): number {
        this.snapCount += 1
        return this.snapCount - 1
    }

    get(index: number, snap_id: number): number {
        let searchArray = this.snapArray[index]
        let start = 0
        let end = searchArray.length

        while (start < end) {
            let mid = (start + end) >> 1

            if (searchArray[mid].s <= snap_id) {
                start = mid + 1
            } else {
                end = mid
            }
        }

        return searchArray[start - 1]?.val || 0
    }
}
