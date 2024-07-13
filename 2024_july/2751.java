class Solution {
    public List<Integer> survivedRobotsHealths(int[] positions, int[] healths, String directions) {
        ArrayList<ArrayList<Integer>> combined = new ArrayList<>();
        
        int n = positions.length;
        for(int i=0; i<n; i++) {
            ArrayList<Integer> temp = new ArrayList<>();
            temp.add(positions[i]);
            temp.add(healths[i]);
            temp.add(directions.charAt(i) == 'R' ? 1 : -1);
            temp.add(i);
            combined.add(temp);
        }
        
        Collections.sort(combined, new Comparator<ArrayList<Integer>>() {
            public int compare(ArrayList<Integer> o1, ArrayList<Integer> o2) {
                return o1.get(0).compareTo(o2.get(0));
            }
        });
        
        List<Integer> result = new ArrayList<>();
        int i=0;
        int j=0;
        Deque<ArrayList<Integer>> deque = new ArrayDeque<>();

        while(j < n) {
            if(j == 0) {
                deque.addLast(combined.get(j));
            } else {
                ArrayList<Integer> current = combined.get(j);
                int currHealth = current.get(1);
                if(current.get(2) == -1) {
                    while(!deque.isEmpty() && deque.peekLast().get(2) == 1) {
                        ArrayList<Integer> prev1 = deque.peekLast();
                        if(deque.peekLast().get(1) < currHealth) {
                            currHealth--;
                            deque.removeLast();
                        } else if(deque.peekLast().get(1) > currHealth) {
                            ArrayList<Integer> prev = deque.pollLast();
                            prev.set(1, prev.get(1) - 1);
                            currHealth = 0;
                            deque.addLast(prev);
                            break;
                        } else {
                            deque.removeLast();
                            currHealth = 0;
                            break;
                        }
                    }

                    if(currHealth > 0) {
                        current.set(1, currHealth);
                        deque.addLast(current);
                    }
                } else {
                    deque.addLast(current);
                }
            }
            j++;
        }
        
        ArrayList<ArrayList<Integer>> temp = new ArrayList<>();
        for(ArrayList<Integer> arr : deque)
            temp.add(arr);
        
        Collections.sort(temp, new Comparator<ArrayList<Integer>>() {
            public int compare(ArrayList<Integer> o1, ArrayList<Integer> o2) {
                return o1.get(3).compareTo(o2.get(3));
            }
        });
        
        for(ArrayList<Integer> arr : temp) {
            result.add(arr.get(1));
        }
        
        return result;
    }
}