﻿using NUnit.Framework;
using System.Collections.Generic;
using Wibci.CountryReverseGeocode.Models;

namespace Wibci.CountryReverseGeocode.Tests
{
    [TestFixture]
    public class CountryReverseGeocodeServiceTests
    {
        private static List<string> SAMPLE_COUNTRY_DATA = new List<string>
        {
            "{'type':'Feature','id':'AFG','properties':{'name':'Afghanistan'},'geometry':{'type':'Polygon','coordinates':[[[61.210817,35.650072],[62.230651,35.270664],[62.984662,35.404041],[63.193538,35.857166],[63.982896,36.007957],[64.546479,36.312073],[64.746105,37.111818],[65.588948,37.305217],[65.745631,37.661164],[66.217385,37.39379],[66.518607,37.362784],[67.075782,37.356144],[67.83,37.144994],[68.135562,37.023115],[68.859446,37.344336],[69.196273,37.151144],[69.518785,37.608997],[70.116578,37.588223],[70.270574,37.735165],[70.376304,38.138396],[70.806821,38.486282],[71.348131,38.258905],[71.239404,37.953265],[71.541918,37.905774],[71.448693,37.065645],[71.844638,36.738171],[72.193041,36.948288],[72.63689,37.047558],[73.260056,37.495257],[73.948696,37.421566],[74.980002,37.41999],[75.158028,37.133031],[74.575893,37.020841],[74.067552,36.836176],[72.920025,36.720007],[71.846292,36.509942],[71.262348,36.074388],[71.498768,35.650563],[71.613076,35.153203],[71.115019,34.733126],[71.156773,34.348911],[70.881803,33.988856],[69.930543,34.02012],[70.323594,33.358533],[69.687147,33.105499],[69.262522,32.501944],[69.317764,31.901412],[68.926677,31.620189],[68.556932,31.71331],[67.792689,31.58293],[67.683394,31.303154],[66.938891,31.304911],[66.381458,30.738899],[66.346473,29.887943],[65.046862,29.472181],[64.350419,29.560031],[64.148002,29.340819],[63.550261,29.468331],[62.549857,29.318572],[60.874248,29.829239],[61.781222,30.73585],[61.699314,31.379506],[60.941945,31.548075],[60.863655,32.18292],[60.536078,32.981269],[60.9637,33.528832],[60.52843,33.676446],[60.803193,34.404102],[61.210817,35.650072]]]}}",
            "{'type':'Feature','id':'AGO','properties':{'name':'Angola'},'geometry':{'type':'MultiPolygon','coordinates':[[[[16.326528,-5.87747],[16.57318,-6.622645],[16.860191,-7.222298],[17.089996,-7.545689],[17.47297,-8.068551],[18.134222,-7.987678],[18.464176,-7.847014],[19.016752,-7.988246],[19.166613,-7.738184],[19.417502,-7.155429],[20.037723,-7.116361],[20.091622,-6.94309],[20.601823,-6.939318],[20.514748,-7.299606],[21.728111,-7.290872],[21.746456,-7.920085],[21.949131,-8.305901],[21.801801,-8.908707],[21.875182,-9.523708],[22.208753,-9.894796],[22.155268,-11.084801],[22.402798,-10.993075],[22.837345,-11.017622],[23.456791,-10.867863],[23.912215,-10.926826],[24.017894,-11.237298],[23.904154,-11.722282],[24.079905,-12.191297],[23.930922,-12.565848],[24.016137,-12.911046],[21.933886,-12.898437],[21.887843,-16.08031],[22.562478,-16.898451],[23.215048,-17.523116],[21.377176,-17.930636],[18.956187,-17.789095],[18.263309,-17.309951],[14.209707,-17.353101],[14.058501,-17.423381],[13.462362,-16.971212],[12.814081,-16.941343],[12.215461,-17.111668],[11.734199,-17.301889],[11.640096,-16.673142],[11.778537,-15.793816],[12.123581,-14.878316],[12.175619,-14.449144],[12.500095,-13.5477],[12.738479,-13.137906],[13.312914,-12.48363],[13.633721,-12.038645],[13.738728,-11.297863],[13.686379,-10.731076],[13.387328,-10.373578],[13.120988,-9.766897],[12.87537,-9.166934],[12.929061,-8.959091],[13.236433,-8.562629],[12.93304,-7.596539],[12.728298,-6.927122],[12.227347,-6.294448],[12.322432,-6.100092],[12.735171,-5.965682],[13.024869,-5.984389],[13.375597,-5.864241],[16.326528,-5.87747]]],[[[12.436688,-5.684304],[12.182337,-5.789931],[11.914963,-5.037987],[12.318608,-4.60623],[12.62076,-4.438023],[12.995517,-4.781103],[12.631612,-4.991271],[12.468004,-5.248362],[12.436688,-5.684304]]]]}}"
        };

        private static List<string> SAMPLE_STATE_DATA = new List<string>
        {
            "{'type':'Feature','id':'USA-AK','properties':{'fips':'02','name':'Alaska'},'geometry':{'type':'MultiPolygon','coordinates':[[[[-131.602021,55.117982],[-131.569159,55.28229],[-131.355558,55.183705],[-131.38842,55.01392],[-131.645836,55.035827],[-131.602021,55.117982]]],[[[-131.832052,55.42469],[-131.645836,55.304197],[-131.749898,55.128935],[-131.832052,55.189182],[-131.832052,55.42469]]],[[[-132.976733,56.437924],[-132.735747,56.459832],[-132.631685,56.421493],[-132.664547,56.273616],[-132.878148,56.240754],[-133.069841,56.333862],[-132.976733,56.437924]]],[[[-133.595627,56.350293],[-133.162949,56.317431],[-133.05341,56.125739],[-132.620732,55.912138],[-132.472854,55.780691],[-132.4619,55.671152],[-132.357838,55.649245],[-132.341408,55.506844],[-132.166146,55.364444],[-132.144238,55.238474],[-132.029222,55.276813],[-131.97993,55.178228],[-131.958022,54.789365],[-132.029222,54.701734],[-132.308546,54.718165],[-132.385223,54.915335],[-132.483808,54.898904],[-132.686455,55.046781],[-132.746701,54.997489],[-132.916486,55.046781],[-132.889102,54.898904],[-132.73027,54.937242],[-132.626209,54.882473],[-132.675501,54.679826],[-132.867194,54.701734],[-133.157472,54.95915],[-133.239626,55.090597],[-133.223195,55.22752],[-133.453227,55.216566],[-133.453227,55.320628],[-133.277964,55.331582],[-133.102702,55.42469],[-133.17938,55.588998],[-133.387503,55.62186],[-133.420365,55.884753],[-133.497042,56.0162],[-133.639442,55.923092],[-133.694212,56.070969],[-133.546335,56.142169],[-133.666827,56.311955],[-133.595627,56.350293]]],[[[-133.738027,55.556137],[-133.546335,55.490413],[-133.414888,55.572568],[-133.283441,55.534229],[-133.420365,55.386352],[-133.633966,55.430167],[-133.738027,55.556137]]],[[[-133.907813,56.930849],[-134.050213,57.029434],[-133.885905,57.095157],[-133.343688,57.002049],[-133.102702,57.007526],[-132.932917,56.82131],[-132.620732,56.667956],[-132.653593,56.55294],[-132.817901,56.492694],[-133.042456,56.520078],[-133.201287,56.448878],[-133.420365,56.492694],[-133.66135,56.448878],[-133.710643,56.684386],[-133.688735,56.837741],[-133.869474,56.843218],[-133.907813,56.930849]]],[[[-134.115936,56.48174],[-134.25286,56.558417],[-134.400737,56.722725],[-134.417168,56.848695],[-134.296675,56.908941],[-134.170706,56.848695],[-134.143321,56.952757],[-133.748981,56.772017],[-133.710643,56.596755],[-133.847566,56.574848],[-133.935197,56.377678],[-133.836612,56.322908],[-133.957105,56.092877],[-134.110459,56.142169],[-134.132367,55.999769],[-134.230952,56.070969],[-134.291198,56.350293],[-134.115936,56.48174]]],[[[-134.636246,56.28457],[-134.669107,56.169554],[-134.806031,56.235277],[-135.178463,56.67891],[-135.413971,56.810356],[-135.331817,56.914418],[-135.424925,57.166357],[-135.687818,57.369004],[-135.419448,57.566174],[-135.298955,57.48402],[-135.063447,57.418296],[-134.849846,57.407343],[-134.844369,57.248511],[-134.636246,56.728202],[-134.636246,56.28457]]],[[[-134.712923,58.223407],[-134.373353,58.14673],[-134.176183,58.157683],[-134.187137,58.081006],[-133.902336,57.807159],[-134.099505,57.850975],[-134.148798,57.757867],[-133.935197,57.615466],[-133.869474,57.363527],[-134.083075,57.297804],[-134.154275,57.210173],[-134.499322,57.029434],[-134.603384,57.034911],[-134.6472,57.226604],[-134.575999,57.341619],[-134.608861,57.511404],[-134.729354,57.719528],[-134.707446,57.829067],[-134.784123,58.097437],[-134.91557,58.212453],[-134.953908,58.409623],[-134.712923,58.223407]]],[[[-135.857603,57.330665],[-135.715203,57.330665],[-135.567326,57.149926],[-135.633049,57.023957],[-135.857603,56.996572],[-135.824742,57.193742],[-135.857603,57.330665]]],[[[-136.279328,58.206976],[-135.978096,58.201499],[-135.780926,58.28913],[-135.496125,58.168637],[-135.64948,58.037191],[-135.59471,57.987898],[-135.45231,58.135776],[-135.107263,58.086483],[-134.91557,57.976944],[-135.025108,57.779775],[-134.937477,57.763344],[-134.822462,57.500451],[-135.085355,57.462112],[-135.572802,57.675713],[-135.556372,57.456635],[-135.709726,57.369004],[-135.890465,57.407343],[-136.000004,57.544266],[-136.208128,57.637374],[-136.366959,57.829067],[-136.569606,57.916698],[-136.558652,58.075529],[-136.421728,58.130299],[-136.377913,58.267222],[-136.279328,58.206976]]],[[[-147.079854,60.200582],[-147.501579,59.948643],[-147.53444,59.850058],[-147.874011,59.784335],[-147.80281,59.937689],[-147.435855,60.09652],[-147.205824,60.271782],[-147.079854,60.200582]]],[[[-147.561825,60.578491],[-147.616594,60.370367],[-147.758995,60.156767],[-147.956165,60.227967],[-147.791856,60.474429],[-147.561825,60.578491]]],[[[-147.786379,70.245291],[-147.682318,70.201475],[-147.162008,70.15766],[-146.888161,70.185044],[-146.510252,70.185044],[-146.099482,70.146706],[-145.858496,70.168614],[-145.622988,70.08646],[-145.195787,69.993352],[-144.620708,69.971444],[-144.461877,70.026213],[-144.078491,70.059075],[-143.914183,70.130275],[-143.497935,70.141229],[-143.503412,70.091936],[-143.25695,70.119321],[-142.747594,70.042644],[-142.402547,69.916674],[-142.079408,69.856428],[-142.008207,69.801659],[-141.712453,69.790705],[-141.433129,69.697597],[-141.378359,69.63735],[-141.208574,69.686643],[-141.00045,69.648304],[-141.00045,60.304644],[-140.53491,60.22249],[-140.474664,60.310121],[-139.987216,60.184151],[-139.696939,60.342983],[-139.088998,60.359413],[-139.198537,60.091043],[-139.045183,59.997935],[-138.700135,59.910304],[-138.623458,59.767904],[-137.604747,59.242118],[-137.445916,58.908024],[-137.265177,59.001132],[-136.827022,59.159963],[-136.580559,59.16544],[-136.465544,59.285933],[-136.476498,59.466672],[-136.301236,59.466672],[-136.25742,59.625503],[-135.945234,59.663842],[-135.479694,59.800766],[-135.025108,59.565257],[-135.068924,59.422857],[-134.959385,59.280456],[-134.701969,59.247595],[-134.378829,59.033994],[-134.400737,58.973748],[-134.25286,58.858732],[-133.842089,58.727285],[-133.173903,58.152206],[-133.075318,57.998852],[-132.867194,57.845498],[-132.560485,57.505928],[-132.253777,57.21565],[-132.368792,57.095157],[-132.05113,57.051341],[-132.127807,56.876079],[-131.870391,56.804879],[-131.837529,56.602232],[-131.580113,56.613186],[-131.087188,56.405062],[-130.78048,56.366724],[-130.621648,56.268139],[-130.468294,56.240754],[-130.424478,56.142169],[-130.101339,56.114785],[-130.002754,55.994292],[-130.150631,55.769737],[-130.128724,55.583521],[-129.986323,55.276813],[-130.095862,55.200136],[-130.336847,54.920812],[-130.687372,54.718165],[-130.785957,54.822227],[-130.917403,54.789365],[-131.010511,54.997489],[-130.983126,55.08512],[-131.092665,55.189182],[-130.862634,55.298721],[-130.928357,55.337059],[-131.158389,55.200136],[-131.284358,55.287767],[-131.426759,55.238474],[-131.843006,55.457552],[-131.700606,55.698537],[-131.963499,55.616383],[-131.974453,55.49589],[-132.182576,55.588998],[-132.226392,55.704014],[-132.083991,55.829984],[-132.127807,55.955953],[-132.324977,55.851892],[-132.522147,56.076446],[-132.642639,56.032631],[-132.719317,56.218847],[-132.527624,56.339339],[-132.341408,56.339339],[-132.396177,56.487217],[-132.297592,56.67891],[-132.450946,56.673433],[-132.768609,56.837741],[-132.993164,57.034911],[-133.51895,57.177311],[-133.507996,57.577128],[-133.677781,57.62642],[-133.639442,57.790728],[-133.814705,57.834544],[-134.072121,58.053622],[-134.143321,58.168637],[-134.586953,58.206976],[-135.074401,58.502731],[-135.282525,59.192825],[-135.38111,59.033994],[-135.337294,58.891593],[-135.140124,58.617746],[-135.189417,58.573931],[-135.05797,58.349376],[-135.085355,58.201499],[-135.277048,58.234361],[-135.430402,58.398669],[-135.633049,58.426053],[-135.91785,58.382238],[-135.912373,58.617746],[-136.087635,58.814916],[-136.246466,58.75467],[-136.876314,58.962794],[-136.931084,58.902547],[-136.586036,58.836824],[-136.317666,58.672516],[-136.213604,58.667039],[-136.180743,58.535592],[-136.043819,58.382238],[-136.388867,58.294607],[-136.591513,58.349376],[-136.59699,58.212453],[-136.859883,58.316515],[-136.947514,58.393192],[-137.111823,58.393192],[-137.566409,58.590362],[-137.900502,58.765624],[-137.933364,58.869686],[-138.11958,59.02304],[-138.634412,59.132579],[-138.919213,59.247595],[-139.417615,59.379041],[-139.746231,59.505011],[-139.718846,59.641934],[-139.625738,59.598119],[-139.5162,59.68575],[-139.625738,59.88292],[-139.488815,59.992458],[-139.554538,60.041751],[-139.801,59.833627],[-140.315833,59.696704],[-140.92925,59.745996],[-141.444083,59.871966],[-141.46599,59.970551],[-141.706976,59.948643],[-141.964392,60.019843],[-142.539471,60.085566],[-142.873564,60.091043],[-143.623905,60.036274],[-143.892275,59.997935],[-144.231845,60.140336],[-144.65357,60.206059],[-144.785016,60.29369],[-144.834309,60.441568],[-145.124586,60.430614],[-145.223171,60.299167],[-145.738004,60.474429],[-145.820158,60.551106],[-146.351421,60.408706],[-146.608837,60.238921],[-146.718376,60.397752],[-146.608837,60.485383],[-146.455483,60.463475],[-145.951604,60.578491],[-146.017328,60.666122],[-146.252836,60.622307],[-146.345944,60.737322],[-146.565022,60.753753],[-146.784099,61.044031],[-146.866253,60.972831],[-147.172962,60.934492],[-147.271547,60.972831],[-147.375609,60.879723],[-147.758995,60.912584],[-147.775426,60.808523],[-148.032842,60.781138],[-148.153334,60.819476],[-148.065703,61.005692],[-148.175242,61.000215],[-148.350504,60.803046],[-148.109519,60.737322],[-148.087611,60.594922],[-147.939734,60.441568],[-148.027365,60.277259],[-148.219058,60.332029],[-148.273827,60.249875],[-148.087611,60.217013],[-147.983549,59.997935],[-148.251919,59.95412],[-148.399797,59.997935],[-148.635305,59.937689],[-148.755798,59.986981],[-149.067984,59.981505],[-149.05703,60.063659],[-149.204907,60.008889],[-149.287061,59.904827],[-149.418508,59.997935],[-149.582816,59.866489],[-149.511616,59.806242],[-149.741647,59.729565],[-149.949771,59.718611],[-150.031925,59.61455],[-150.25648,59.521442],[-150.409834,59.554303],[-150.579619,59.444764],[-150.716543,59.450241],[-151.001343,59.225687],[-151.308052,59.209256],[-151.406637,59.280456],[-151.592853,59.159963],[-151.976239,59.253071],[-151.888608,59.422857],[-151.636669,59.483103],[-151.47236,59.472149],[-151.423068,59.537872],[-151.127313,59.669319],[-151.116359,59.778858],[-151.505222,59.63098],[-151.828361,59.718611],[-151.8667,59.778858],[-151.702392,60.030797],[-151.423068,60.211536],[-151.379252,60.359413],[-151.297098,60.386798],[-151.264237,60.545629],[-151.406637,60.720892],[-151.06159,60.786615],[-150.404357,61.038554],[-150.245526,60.939969],[-150.042879,60.912584],[-149.741647,61.016646],[-150.075741,61.15357],[-150.207187,61.257632],[-150.47008,61.246678],[-150.656296,61.29597],[-150.711066,61.252155],[-151.023251,61.180954],[-151.165652,61.044031],[-151.477837,61.011169],[-151.800977,60.852338],[-151.833838,60.748276],[-152.080301,60.693507],[-152.13507,60.578491],[-152.310332,60.507291],[-152.392486,60.304644],[-152.732057,60.173197],[-152.567748,60.069136],[-152.704672,59.915781],[-153.022334,59.888397],[-153.049719,59.691227],[-153.345474,59.620026],[-153.438582,59.702181],[-153.586459,59.548826],[-153.761721,59.543349],[-153.72886,59.433811],[-154.117723,59.368087],[-154.1944,59.066856],[-153.750768,59.050425],[-153.400243,58.968271],[-153.301658,58.869686],[-153.444059,58.710854],[-153.679567,58.612269],[-153.898645,58.606793],[-153.920553,58.519161],[-154.062953,58.4863],[-153.99723,58.376761],[-154.145107,58.212453],[-154.46277,58.059098],[-154.643509,58.059098],[-154.818771,58.004329],[-154.988556,58.015283],[-155.120003,57.955037],[-155.081664,57.872883],[-155.328126,57.829067],[-155.377419,57.708574],[-155.547204,57.785251],[-155.73342,57.549743],[-156.045606,57.566174],[-156.023698,57.440204],[-156.209914,57.473066],[-156.34136,57.418296],[-156.34136,57.248511],[-156.549484,56.985618],[-156.883577,56.952757],[-157.157424,56.832264],[-157.20124,56.766541],[-157.376502,56.859649],[-157.672257,56.607709],[-157.754411,56.67891],[-157.918719,56.657002],[-157.957058,56.514601],[-158.126843,56.459832],[-158.32949,56.48174],[-158.488321,56.339339],[-158.208997,56.295524],[-158.510229,55.977861],[-159.375585,55.873799],[-159.616571,55.594475],[-159.676817,55.654722],[-159.643955,55.829984],[-159.813741,55.857368],[-160.027341,55.791645],[-160.060203,55.720445],[-160.394296,55.605429],[-160.536697,55.473983],[-160.580512,55.567091],[-160.668143,55.457552],[-160.865313,55.528752],[-161.232268,55.358967],[-161.506115,55.364444],[-161.467776,55.49589],[-161.588269,55.62186],[-161.697808,55.517798],[-161.686854,55.408259],[-162.053809,55.074166],[-162.179779,55.15632],[-162.218117,55.03035],[-162.470057,55.052258],[-162.508395,55.249428],[-162.661749,55.293244],[-162.716519,55.222043],[-162.579595,55.134412],[-162.645319,54.997489],[-162.847965,54.926289],[-163.00132,55.079643],[-163.187536,55.090597],[-163.220397,55.03035],[-163.034181,54.942719],[-163.373752,54.800319],[-163.14372,54.76198],[-163.138243,54.696257],[-163.329936,54.74555],[-163.587352,54.614103],[-164.085754,54.61958],[-164.332216,54.531949],[-164.354124,54.466226],[-164.638925,54.389548],[-164.847049,54.416933],[-164.918249,54.603149],[-164.710125,54.663395],[-164.551294,54.88795],[-164.34317,54.893427],[-163.894061,55.041304],[-163.532583,55.046781],[-163.39566,54.904381],[-163.291598,55.008443],[-163.313505,55.128935],[-163.105382,55.183705],[-162.880827,55.183705],[-162.579595,55.446598],[-162.245502,55.682106],[-161.807347,55.89023],[-161.292514,55.983338],[-161.078914,55.939523],[-160.87079,55.999769],[-160.816021,55.912138],[-160.931036,55.813553],[-160.805067,55.736876],[-160.766728,55.857368],[-160.509312,55.868322],[-160.438112,55.791645],[-160.27928,55.76426],[-160.273803,55.857368],[-160.536697,55.939523],[-160.558604,55.994292],[-160.383342,56.251708],[-160.147834,56.399586],[-159.830171,56.541986],[-159.326293,56.667956],[-158.959338,56.848695],[-158.784076,56.782971],[-158.641675,56.810356],[-158.701922,56.925372],[-158.658106,57.034911],[-158.378782,57.264942],[-157.995396,57.41282],[-157.688688,57.609989],[-157.705118,57.719528],[-157.458656,58.497254],[-157.07527,58.705377],[-157.119086,58.869686],[-158.039212,58.634177],[-158.32949,58.661562],[-158.40069,58.760147],[-158.564998,58.803962],[-158.619768,58.913501],[-158.767645,58.864209],[-158.860753,58.694424],[-158.701922,58.480823],[-158.893615,58.387715],[-159.0634,58.420577],[-159.392016,58.760147],[-159.616571,58.929932],[-159.731586,58.929932],[-159.808264,58.803962],[-159.906848,58.782055],[-160.054726,58.886116],[-160.235465,58.902547],[-160.317619,59.072332],[-160.854359,58.88064],[-161.33633,58.743716],[-161.374669,58.667039],[-161.752577,58.552023],[-161.938793,58.656085],[-161.769008,58.776578],[-161.829255,59.061379],[-161.955224,59.36261],[-161.703285,59.48858],[-161.911409,59.740519],[-162.092148,59.88292],[-162.234548,60.091043],[-162.448149,60.178674],[-162.502918,59.997935],[-162.760334,59.959597],[-163.171105,59.844581],[-163.66403,59.795289],[-163.9324,59.806242],[-164.162431,59.866489],[-164.189816,60.02532],[-164.386986,60.074613],[-164.699171,60.29369],[-164.962064,60.337506],[-165.268773,60.578491],[-165.060649,60.68803],[-165.016834,60.890677],[-165.175665,60.846861],[-165.197573,60.972831],[-165.120896,61.076893],[-165.323543,61.170001],[-165.34545,61.071416],[-165.591913,61.109754],[-165.624774,61.279539],[-165.816467,61.301447],[-165.920529,61.416463],[-165.915052,61.558863],[-166.106745,61.49314],[-166.139607,61.630064],[-165.904098,61.662925],[-166.095791,61.81628],[-165.756221,61.827233],[-165.756221,62.013449],[-165.674067,62.139419],[-165.044219,62.539236],[-164.912772,62.659728],[-164.819664,62.637821],[-164.874433,62.807606],[-164.633448,63.097884],[-164.425324,63.212899],[-164.036462,63.262192],[-163.73523,63.212899],[-163.313505,63.037637],[-163.039658,63.059545],[-162.661749,63.22933],[-162.272887,63.486746],[-162.075717,63.514131],[-162.026424,63.448408],[-161.555408,63.448408],[-161.13916,63.503177],[-160.766728,63.771547],[-160.766728,63.837271],[-160.952944,64.08921],[-160.974852,64.237087],[-161.26513,64.395918],[-161.374669,64.532842],[-161.078914,64.494503],[-160.79959,64.609519],[-160.783159,64.719058],[-161.144637,64.921705],[-161.413007,64.762873],[-161.664946,64.790258],[-161.900455,64.702627],[-162.168825,64.680719],[-162.234548,64.620473],[-162.541257,64.532842],[-162.634365,64.384965],[-162.787719,64.324718],[-162.858919,64.49998],[-163.045135,64.538319],[-163.176582,64.401395],[-163.253259,64.467119],[-163.598306,64.565704],[-164.304832,64.560227],[-164.80871,64.450688],[-165.000403,64.434257],[-165.411174,64.49998],[-166.188899,64.576658],[-166.391546,64.636904],[-166.484654,64.735489],[-166.413454,64.872412],[-166.692778,64.987428],[-166.638008,65.113398],[-166.462746,65.179121],[-166.517516,65.337952],[-166.796839,65.337952],[-167.026871,65.381768],[-167.47598,65.414629],[-167.711489,65.496784],[-168.072967,65.578938],[-168.105828,65.682999],[-167.541703,65.819923],[-166.829701,66.049954],[-166.3313,66.186878],[-166.046499,66.110201],[-165.756221,66.09377],[-165.690498,66.203309],[-165.86576,66.21974],[-165.88219,66.312848],[-165.186619,66.466202],[-164.403417,66.581218],[-163.981692,66.592172],[-163.751661,66.553833],[-163.872153,66.389525],[-163.828338,66.274509],[-163.915969,66.192355],[-163.768091,66.060908],[-163.494244,66.082816],[-163.149197,66.060908],[-162.749381,66.088293],[-162.634365,66.039001],[-162.371472,66.028047],[-162.14144,66.077339],[-161.840208,66.02257],[-161.549931,66.241647],[-161.341807,66.252601],[-161.199406,66.208786],[-161.128206,66.334755],[-161.528023,66.395002],[-161.911409,66.345709],[-161.87307,66.510017],[-162.174302,66.68528],[-162.502918,66.740049],[-162.601503,66.89888],[-162.344087,66.937219],[-162.015471,66.778388],[-162.075717,66.652418],[-161.916886,66.553833],[-161.571838,66.438817],[-161.489684,66.55931],[-161.884024,66.718141],[-161.714239,67.002942],[-161.851162,67.052235],[-162.240025,66.991988],[-162.639842,67.008419],[-162.700088,67.057712],[-162.902735,67.008419],[-163.740707,67.128912],[-163.757138,67.254881],[-164.009077,67.534205],[-164.211724,67.638267],[-164.534863,67.725898],[-165.192096,67.966884],[-165.493328,68.059992],[-165.794559,68.081899],[-166.243668,68.246208],[-166.681824,68.339316],[-166.703731,68.372177],[-166.375115,68.42147],[-166.227238,68.574824],[-166.216284,68.881533],[-165.329019,68.859625],[-164.255539,68.930825],[-163.976215,68.985595],[-163.532583,69.138949],[-163.110859,69.374457],[-163.023228,69.609966],[-162.842489,69.812613],[-162.470057,69.982398],[-162.311225,70.108367],[-161.851162,70.311014],[-161.779962,70.256245],[-161.396576,70.239814],[-160.837928,70.343876],[-160.487404,70.453415],[-159.649432,70.792985],[-159.33177,70.809416],[-159.298908,70.760123],[-158.975769,70.798462],[-158.658106,70.787508],[-158.033735,70.831323],[-157.420318,70.979201],[-156.812377,71.285909],[-156.565915,71.351633],[-156.522099,71.296863],[-155.585543,71.170894],[-155.508865,71.083263],[-155.832005,70.968247],[-155.979882,70.96277],[-155.974405,70.809416],[-155.503388,70.858708],[-155.476004,70.940862],[-155.262403,71.017539],[-155.191203,70.973724],[-155.032372,71.148986],[-154.566832,70.990155],[-154.643509,70.869662],[-154.353231,70.8368],[-154.183446,70.7656],[-153.931507,70.880616],[-153.487874,70.886093],[-153.235935,70.924431],[-152.589656,70.886093],[-152.26104,70.842277],[-152.419871,70.606769],[-151.817408,70.546523],[-151.773592,70.486276],[-151.187559,70.382214],[-151.182082,70.431507],[-150.760358,70.49723],[-150.355064,70.491753],[-150.349588,70.436984],[-150.114079,70.431507],[-149.867617,70.508184],[-149.462323,70.519138],[-149.177522,70.486276],[-148.78866,70.404122],[-148.607921,70.420553],[-148.350504,70.305537],[-148.202627,70.349353],[-147.961642,70.316491],[-147.786379,70.245291]]],[[[-152.94018,58.026237],[-152.945657,57.982421],[-153.290705,58.048145],[-153.044242,58.305561],[-152.819688,58.327469],[-152.666333,58.562977],[-152.496548,58.354853],[-152.354148,58.426053],[-152.080301,58.311038],[-152.080301,58.152206],[-152.480117,58.130299],[-152.655379,58.059098],[-152.94018,58.026237]]],[[[-153.958891,57.538789],[-153.67409,57.670236],[-153.931507,57.69762],[-153.936983,57.812636],[-153.723383,57.889313],[-153.570028,57.834544],[-153.548121,57.719528],[-153.46049,57.796205],[-153.455013,57.96599],[-153.268797,57.889313],[-153.235935,57.998852],[-153.071627,57.933129],[-152.874457,57.933129],[-152.721103,57.993375],[-152.469163,57.889313],[-152.469163,57.599035],[-152.151501,57.620943],[-152.359625,57.42925],[-152.74301,57.505928],[-152.60061,57.379958],[-152.710149,57.275896],[-152.907319,57.325188],[-152.912796,57.128019],[-153.214027,57.073249],[-153.312612,56.991095],[-153.498828,57.067772],[-153.695998,56.859649],[-153.849352,56.837741],[-154.013661,56.744633],[-154.073907,56.969187],[-154.303938,56.848695],[-154.314892,56.919895],[-154.523016,56.991095],[-154.539447,57.193742],[-154.742094,57.275896],[-154.627078,57.511404],[-154.227261,57.659282],[-153.980799,57.648328],[-153.958891,57.538789]]],[[[-154.53397,56.602232],[-154.742094,56.399586],[-154.807817,56.432447],[-154.53397,56.602232]]],[[[-155.634835,55.923092],[-155.476004,55.912138],[-155.530773,55.704014],[-155.793666,55.731399],[-155.837482,55.802599],[-155.634835,55.923092]]],[[[-159.890418,55.28229],[-159.950664,55.068689],[-160.257373,54.893427],[-160.109495,55.161797],[-160.005433,55.134412],[-159.890418,55.28229]]],[[[-160.520266,55.358967],[-160.33405,55.358967],[-160.339527,55.249428],[-160.525743,55.128935],[-160.690051,55.211089],[-160.794113,55.134412],[-160.854359,55.320628],[-160.79959,55.380875],[-160.520266,55.358967]]],[[[-162.256456,54.981058],[-162.234548,54.893427],[-162.349564,54.838658],[-162.437195,54.931766],[-162.256456,54.981058]]],[[[-162.415287,63.634624],[-162.563165,63.536039],[-162.612457,63.62367],[-162.415287,63.634624]]],[[[-162.80415,54.488133],[-162.590549,54.449795],[-162.612457,54.367641],[-162.782242,54.373118],[-162.80415,54.488133]]],[[[-165.548097,54.29644],[-165.476897,54.181425],[-165.630251,54.132132],[-165.685021,54.252625],[-165.548097,54.29644]]],[[[-165.73979,54.15404],[-166.046499,54.044501],[-166.112222,54.121178],[-165.980775,54.219763],[-165.73979,54.15404]]],[[[-166.364161,60.359413],[-166.13413,60.397752],[-166.084837,60.326552],[-165.88219,60.342983],[-165.685021,60.277259],[-165.646682,59.992458],[-165.750744,59.89935],[-166.00816,59.844581],[-166.062929,59.745996],[-166.440838,59.855535],[-166.6161,59.850058],[-166.994009,59.992458],[-167.125456,59.992458],[-167.344534,60.074613],[-167.421211,60.206059],[-167.311672,60.238921],[-166.93924,60.206059],[-166.763978,60.310121],[-166.577762,60.321075],[-166.495608,60.392275],[-166.364161,60.359413]]],[[[-166.375115,54.01164],[-166.210807,53.934962],[-166.5449,53.748746],[-166.539423,53.715885],[-166.117699,53.852808],[-166.112222,53.776131],[-166.282007,53.683023],[-166.555854,53.622777],[-166.583239,53.529669],[-166.878994,53.431084],[-167.13641,53.425607],[-167.306195,53.332499],[-167.623857,53.250345],[-167.793643,53.337976],[-167.459549,53.442038],[-167.355487,53.425607],[-167.103548,53.513238],[-167.163794,53.611823],[-167.021394,53.715885],[-166.807793,53.666592],[-166.785886,53.732316],[-167.015917,53.754223],[-167.141887,53.825424],[-167.032348,53.945916],[-166.643485,54.017116],[-166.561331,53.880193],[-166.375115,54.01164]]],[[[-168.790446,53.157237],[-168.40706,53.34893],[-168.385152,53.431084],[-168.237275,53.524192],[-168.007243,53.568007],[-167.886751,53.518715],[-167.842935,53.387268],[-168.270136,53.244868],[-168.500168,53.036744],[-168.686384,52.965544],[-168.790446,53.157237]]],[[[-169.74891,52.894344],[-169.705095,52.795759],[-169.962511,52.790282],[-169.989896,52.856005],[-169.74891,52.894344]]],[[[-170.148727,57.221127],[-170.28565,57.128019],[-170.313035,57.221127],[-170.148727,57.221127]]],[[[-170.669036,52.697174],[-170.603313,52.604066],[-170.789529,52.538343],[-170.816914,52.636928],[-170.669036,52.697174]]],[[[-171.742517,63.716778],[-170.94836,63.5689],[-170.488297,63.69487],[-170.280174,63.683916],[-170.093958,63.612716],[-170.044665,63.492223],[-169.644848,63.4265],[-169.518879,63.366254],[-168.99857,63.338869],[-168.686384,63.295053],[-168.856169,63.147176],[-169.108108,63.180038],[-169.376478,63.152653],[-169.513402,63.08693],[-169.639372,62.939052],[-169.831064,63.075976],[-170.055619,63.169084],[-170.263743,63.180038],[-170.362328,63.2841],[-170.866206,63.415546],[-171.101715,63.421023],[-171.463193,63.306007],[-171.73704,63.366254],[-171.852055,63.486746],[-171.742517,63.716778]]],[[[-172.432611,52.390465],[-172.41618,52.275449],[-172.607873,52.253542],[-172.569535,52.352127],[-172.432611,52.390465]]],[[[-173.626584,52.14948],[-173.495138,52.105664],[-173.122706,52.111141],[-173.106275,52.07828],[-173.549907,52.028987],[-173.626584,52.14948]]],[[[-174.322156,52.280926],[-174.327632,52.379511],[-174.185232,52.41785],[-173.982585,52.319265],[-174.059262,52.226157],[-174.179755,52.231634],[-174.141417,52.127572],[-174.333109,52.116618],[-174.738403,52.007079],[-174.968435,52.039941],[-174.902711,52.116618],[-174.656249,52.105664],[-174.322156,52.280926]]],[[[-176.469116,51.853725],[-176.288377,51.870156],[-176.288377,51.744186],[-176.518409,51.760617],[-176.80321,51.61274],[-176.912748,51.80991],[-176.792256,51.815386],[-176.775825,51.963264],[-176.627947,51.968741],[-176.627947,51.859202],[-176.469116,51.853725]]],[[[-177.153734,51.946833],[-177.044195,51.897541],[-177.120872,51.727755],[-177.274226,51.678463],[-177.279703,51.782525],[-177.153734,51.946833]]],[[[-178.123152,51.919448],[-177.953367,51.913971],[-177.800013,51.793479],[-177.964321,51.651078],[-178.123152,51.919448]]],[[[173.107557,52.992929],[173.293773,52.927205],[173.304726,52.823143],[172.90491,52.762897],[172.642017,52.927205],[172.642017,53.003883],[173.107557,52.992929]]]]}}",
            "{'type':'Feature','id':'USA-AL','properties':{'fips':'01','name':'Alabama'},'geometry':{'type':'Polygon','coordinates':[[[-87.359296, 35.00118],[-85.606675, 34.984749],[-85.431413, 34.124869],[-85.184951, 32.859696],[-85.069935, 32.580372],[-84.960397, 32.421541],[-85.004212, 32.322956],[-84.889196, 32.262709],[-85.058981, 32.13674],[-85.053504, 32.01077],[-85.141136, 31.840985],[-85.042551, 31.539753],[-85.113751, 31.27686],[-85.004212, 31.003013],[-85.497137, 30.997536],[-87.600282, 30.997536],[-87.633143, 30.86609],[-87.408589, 30.674397],[-87.446927, 30.510088],[-87.37025, 30.427934],[-87.518128, 30.280057],[-87.655051, 30.247195],[-87.90699, 30.411504],[-87.934375, 30.657966],[-88.011052, 30.685351],[-88.10416, 30.499135],[-88.137022, 30.318396],[-88.394438, 30.367688],[-88.471115, 31.895754],[-88.241084, 33.796253],[-88.098683, 34.891641],[-88.202745, 34.995703],[-87.359296, 35.00118]]]}"
        };

        private CountryReverseGeocodeService _service;

        [Test]
        public void GetCountry_ForInsideMultiPolygon_FindsCountry()
        {
            //Arrange
            //Buco Zau -4.895250, 12.437329
            GeoLocation angola = new GeoLocation { Latitude = 12.437329, Longitude = -4.895250 };

            //Act
            var info = _service.FindCountry(angola);

            //Assert
            Assert.NotNull(info, "Expected to find area information");
            Assert.AreEqual("Angola", info.Name, "Expected to return 'Angola' as a country");
        }

        [Test]
        public void GetCountry_ForInsidePolygon_FindsCountry()
        {
            //Arrange
            //35.227575, 65.167173
            GeoLocation afghanistan = new GeoLocation { Latitude = 65.167173, Longitude = 35.227575 };

            //Act
            var info = _service.FindCountry(afghanistan);

            //Assert
            Assert.NotNull(info, "Expected to find area information");
            Assert.AreEqual("Afghanistan", info.Name, "Expected to return 'Afghanistan' as country");
        }

        [Test]
        public void GetCountry_ForOutsideMultiPolygon_DoesNotFindCountry()
        {
            //Arrange
            //Bering Sea
            GeoLocation alaskaOcean = new GeoLocation { Latitude = -172.060482, Longitude = 62.510037 };

            //Act
            var info = _service.FindCountry(alaskaOcean);

            //Assert
            Assert.Null(info, "Expected not to find area information for coordinate outside the states");
        }

        [Test]
        [Ignore("Currently polygon for russia seems to be broken for this coordinates")]
        public void GetCountry_ForRussiaBug_FindsCountry()
        {
            //Arrange
            GeoLocation location = new GeoLocation { Latitude = 50.064546, Longitude = 40.587502 };

            //Act
            var info = _service.FindCountry(location);

            //Assert
            Assert.NotNull(info, "Expected to find area information");
            Assert.AreEqual("Russia", info.Name, "Expected to return 'Russia' as a country");
        }

        [Test]
        public void GetState_ForInsideMultiPolygon_FindsState()
        {
            //Arrange
            //Savoonga Island
            GeoLocation alaska = new GeoLocation { Latitude = -170.333949, Longitude = 63.431027 };

            //Act
            var info = _service.FindUsaState(alaska);

            //Assert
            Assert.NotNull(info, "Expected to find area information");
            Assert.AreEqual("Alaska", info.Name, "Expected to return 'Alaska' as state");
        }

        [Test]
        public void GetState_ForInsidePolygon_FindsState()
        {
            //Arrange
            GeoLocation alabama = new GeoLocation { Latitude = -87.762676, Longitude = 34.305190 };

            //Act
            var info = _service.FindUsaState(alabama);

            //Assert
            Assert.NotNull(info, "Expected to find area information");
            Assert.AreEqual("Alabama", info.Name, "Expected to return 'Alabama' as state");
        }

        [Test]
        public void GetState_ForOutsidePolygon_DoesNotFindState()
        {
            //Arrange

            //capetown
            GeoLocation capetown = new GeoLocation { Latitude = 18.751451, Longitude = -33.855952 };

            //Act
            var info = _service.FindUsaState(capetown);

            //Assert
            Assert.Null(info, "Expected not to find area information for coordinate outside the states");
        }

        [SetUp]
        public void Setup()
        {
            _service = new CountryReverseGeocodeService();
        }
    }
}