import http from 'k6/http';
import {sleep, check} from 'k6';

// export const options = {
//     vus : 50,
//     duration : '30s',
//     insecureSkipTLSVerify: true,

// };

export const options ={
    stages :[
        {duration:'10s' , target : 25},
        {duration:'15s' , target : 50},
        {duration:'10s' , target : 0}
    ]
}

export default function () {
    let url = 'https://localhost:7078/api/Calculator?a=5&b=10';
    let res = http.get(url);
    check(res, {
        "is status 200": (r) => r.status === 200,
    });
}