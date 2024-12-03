using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium177p : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium177p";
        public override double halfLife { get; } = 13858560.0d;
        public override double atomicWeight { get; } = 176.94481d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.773d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium177()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.001472d, new GammaParticle(14050.0, 0.08824)), new(0.01955d, new GammaParticle(55150.0, 0.02248)), new(9.900000000000001e-05d, new GammaParticle(69200.0, 0.01792)), new(0.00876d, new GammaParticle(71641.8, 0.01731)), new(0.00043d, new GammaParticle(88400.0, 0.01403)), new(0.1268d, new GammaParticle(105358.9, 0.01177)), new(0.214d, new GammaParticle(112949.8, 0.01098)), new(0.00194d, new GammaParticle(117144.2, 0.01058)), new(0.1604d, new GammaParticle(128502.7, 0.00965)), new(0.01452d, new GammaParticle(136724.5, 0.00907)), new(0.009649999999999999d, new GammaParticle(145769.3, 0.00851)), new(0.1654d, new GammaParticle(153284.2, 0.00809)), new(0.00534d, new GammaParticle(159734.1, 0.00776)), new(0.1247d, new GammaParticle(174398.8, 0.00711)), new(0.0363d, new GammaParticle(177000.7, 0.007)), new(0.00098d, new GammaParticle(181909.3, 0.00682)), new(0.00124d, new GammaParticle(203000.0, 0.00611)), new(0.1351d, new GammaParticle(204105.0, 0.00607)), new(0.5539999999999999d, new GammaParticle(208366.2, 0.00595)), new(0.0643d, new GammaParticle(214434.1, 0.00578)), new(0.000129d, new GammaParticle(223300.0, 0.00555)), new(0.359d, new GammaParticle(228483.8, 0.00543)), new(0.04650000000000001d, new GammaParticle(233861.5, 0.0053)), new(0.000578d, new GammaParticle(242100.0, 0.00512)), new(0.062400000000000004d, new GammaParticle(249674.2, 0.00497)), new(0.13970000000000002d, new GammaParticle(281786.8, 0.0044)), new(0.0041199999999999995d, new GammaParticle(283609.0, 0.00437)), new(0.010320000000000001d, new GammaParticle(291542.9, 0.00425)), new(0.008100000000000001d, new GammaParticle(292526.6, 0.00424)), new(0.0501d, new GammaParticle(296458.4, 0.00418)), new(0.0163d, new GammaParticle(299053.4, 0.00415)), new(0.01799d, new GammaParticle(305503.3, 0.00406)), new(0.01312d, new GammaParticle(313725.0, 0.00395)), new(0.01164d, new GammaParticle(321315.9, 0.00386)), new(0.1843d, new GammaParticle(327682.9, 0.00378)), new(0.0176d, new GammaParticle(341643.2, 0.00363)), new(0.294d, new GammaParticle(378503.6, 0.00328)), new(0.0317d, new GammaParticle(385030.4, 0.00322)), new(0.21719999999999998d, new GammaParticle(418538.8, 0.00296)), new(0.0048d, new GammaParticle(426472.6, 0.00291)), new(0.02471d, new GammaParticle(465841.6, 0.00266)), new(0.444286326760692d, new GammaParticle(9114.0, 0.13604)), new(0.33026103414747027d, new GammaParticle(54608.0, 0.0227)), new(0.5779857090435251d, new GammaParticle(55786.0, 0.02222)), new(0.19068163669203217d, new GammaParticle(63333.0, 0.01958)), new(0.24159363368880474d, new GammaParticle(64057.0, 0.01936)), new(0.05091199699677259d, new GammaParticle(64935.0, 0.01909)) } },
            { 0.22699999999999998d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium177()), new(0.00658d, new GammaParticle(115868.2, 0.0107)), new(0.0629d, new GammaParticle(121621.1, 0.01019)), new(2.2e-06d, new GammaParticle(125300.0, 0.00989)), new(0.0359d, new GammaParticle(147163.7, 0.00842)), new(0.048d, new GammaParticle(171857.4, 0.00721)), new(0.00855d, new GammaParticle(195560.2, 0.00634)), new(0.0337d, new GammaParticle(218103.8, 0.00568)), new(0.0349d, new GammaParticle(268784.7, 0.00461)), new(0.1051d, new GammaParticle(319021.0, 0.00389)), new(1.8e-05d, new GammaParticle(333100.0, 0.00372)), new(1.838e-05d, new GammaParticle(334000.0, 0.00371)), new(0.0313d, new GammaParticle(367417.4, 0.00337)), new(0.17620000000000002d, new GammaParticle(413663.7, 0.003)), new(0.086d, new GammaParticle(8810.0, 0.14073)), new(0.053d, new GammaParticle(52965.0, 0.02341)), new(0.09300000000000001d, new GammaParticle(54070.0, 0.02293)), new(0.030600000000000002d, new GammaParticle(61387.0, 0.0202)), new(0.0387d, new GammaParticle(62084.0, 0.01997)), new(0.008100000000000001d, new GammaParticle(62927.0, 0.0197)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.013108d },
            { 500.0d, 0.0133041d },
            { 1000.0d, 0.0133709d },
            { 1500.0d, 0.0133084d },
            { 2000.0d, 0.0132399d },
            { 2500.0d, 0.0131744d },
            { 3000.0d, 0.0131114d },
            { 3500.0d, 0.0130497d },
            { 4000.0d, 0.0129886d },
            { 4500.0d, 0.0129275d },
            { 5000.0d, 0.0128662d },
            { 5500.0d, 0.0128045d },
            { 6000.0d, 0.0127424d },
            { 6500.0d, 0.0126798d },
            { 7000.0d, 0.0126168d },
            { 7500.0d, 0.0125535d },
            { 8000.0d, 0.0124897d },
            { 8500.0d, 0.0124257d },
            { 9000.0d, 0.0123613d },
            { 9500.0d, 0.0122967d },
            { 10000.0d, 0.0122319d },
            { 10500.0d, 0.0121669d },
            { 11000.0d, 0.0121017d },
            { 11500.0d, 0.0120364d },
            { 12000.0d, 0.011971d },
            { 12500.0d, 0.0119054d },
            { 13000.0d, 0.0118398d },
            { 13500.0d, 0.0117741d },
            { 14000.0d, 0.0117084d },
            { 14500.0d, 0.0116426d },
            { 15000.0d, 0.0115768d },
            { 15500.0d, 0.0115109d },
            { 16000.0d, 0.0114451d },
            { 16500.0d, 0.0113792d },
            { 17000.0d, 0.0113133d },
            { 17500.0d, 0.0112475d },
            { 18000.0d, 0.0111816d },
            { 18500.0d, 0.0111158d },
            { 19000.0d, 0.01105d },
            { 19500.0d, 0.0109842d },
            { 20000.0d, 0.0109184d },
            { 20500.0d, 0.0108527d },
            { 21000.0d, 0.0107871d },
            { 21500.0d, 0.0107214d },
            { 22000.0d, 0.0106558d },
            { 22500.0d, 0.0105903d },
            { 23000.0d, 0.0105248d },
            { 23500.0d, 0.0104594d },
            { 24000.0d, 0.010394d },
            { 24500.0d, 0.0103287d },
            { 25000.0d, 0.0102634d },
            { 25500.0d, 0.0101982d },
            { 26000.0d, 0.0101331d },
            { 26500.0d, 0.010068d },
            { 27000.0d, 0.0100031d },
            { 27500.0d, 0.00993815d },
            { 28000.0d, 0.00987332d },
            { 28500.0d, 0.00980856d },
            { 29000.0d, 0.00974387d },
            { 29500.0d, 0.00967927d },
            { 30000.0d, 0.00961476d },
            { 30500.0d, 0.00955032d },
            { 31000.0d, 0.00948597d },
            { 31500.0d, 0.00942171d },
            { 32000.0d, 0.00935754d },
            { 32500.0d, 0.00929347d },
            { 33000.0d, 0.00922948d },
            { 33500.0d, 0.00916559d },
            { 34000.0d, 0.00910179d },
            { 34500.0d, 0.0090381d },
            { 35000.0d, 0.0089745d },
            { 35500.0d, 0.00891101d },
            { 36000.0d, 0.00884762d },
            { 36500.0d, 0.00878433d },
            { 37000.0d, 0.00872115d },
            { 37500.0d, 0.00865807d },
            { 38000.0d, 0.00859511d },
            { 38500.0d, 0.00853225d },
            { 39000.0d, 0.00846951d },
            { 39500.0d, 0.00840689d },
            { 40000.0d, 0.00834438d },
            { 40500.0d, 0.00828198d },
            { 41000.0d, 0.0082197d },
            { 41500.0d, 0.00815755d },
            { 42000.0d, 0.00809551d },
            { 42500.0d, 0.0080336d },
            { 43000.0d, 0.00797181d },
            { 43500.0d, 0.00791015d },
            { 44000.0d, 0.00784862d },
            { 44500.0d, 0.00778722d },
            { 45000.0d, 0.00772594d },
            { 45500.0d, 0.0076648d },
            { 46000.0d, 0.00760379d },
            { 46500.0d, 0.00754292d },
            { 47000.0d, 0.00748218d },
            { 47500.0d, 0.00742158d },
            { 48000.0d, 0.00736112d },
            { 48500.0d, 0.0073008d },
            { 49000.0d, 0.00724062d },
            { 49500.0d, 0.00718058d },
            { 50000.0d, 0.00712069d },
            { 50500.0d, 0.00706095d },
            { 51000.0d, 0.00700135d },
            { 51500.0d, 0.00694191d },
            { 52000.0d, 0.00688261d },
            { 52500.0d, 0.00682347d },
            { 53000.0d, 0.00676448d },
            { 53500.0d, 0.00670564d },
            { 54000.0d, 0.00664696d },
            { 54500.0d, 0.00658844d },
            { 55000.0d, 0.00653008d },
            { 55500.0d, 0.00647187d },
            { 56000.0d, 0.00641383d },
            { 56500.0d, 0.00635596d },
            { 57000.0d, 0.00629825d },
            { 57500.0d, 0.0062407d },
            { 58000.0d, 0.00618332d },
            { 58500.0d, 0.00612611d },
            { 59000.0d, 0.00606908d },
            { 59500.0d, 0.00601221d },
            { 60000.0d, 0.00595552d },
            { 60500.0d, 0.005899d },
            { 61000.0d, 0.00584265d },
            { 61500.0d, 0.00578649d },
            { 62000.0d, 0.0057305d },
            { 62500.0d, 0.0056747d },
            { 63000.0d, 0.00561907d },
            { 63500.0d, 0.00556363d },
            { 64000.0d, 0.00550837d },
            { 64500.0d, 0.0054533d },
            { 65000.0d, 0.00539842d },
            { 65500.0d, 0.00534372d },
            { 66000.0d, 0.00528922d },
            { 66500.0d, 0.00523491d },
            { 67000.0d, 0.00518079d },
            { 67500.0d, 0.00512686d },
            { 68000.0d, 0.00507313d },
            { 68500.0d, 0.0050196d },
            { 69000.0d, 0.00496626d },
            { 69500.0d, 0.00491313d },
            { 70000.0d, 0.00486019d },
            { 70500.0d, 0.00480746d },
            { 71000.0d, 0.00475493d },
            { 71500.0d, 0.00470261d },
            { 72000.0d, 0.0046505d },
            { 72500.0d, 0.00459859d },
            { 73000.0d, 0.0045469d },
            { 73500.0d, 0.00449541d },
            { 74000.0d, 0.00444414d },
            { 74500.0d, 0.00439308d },
            { 75000.0d, 0.00434224d },
            { 75500.0d, 0.00429161d },
            { 76000.0d, 0.0042412d },
            { 76500.0d, 0.00419101d },
            { 77000.0d, 0.00414105d },
            { 77500.0d, 0.0040913d },
            { 78000.0d, 0.00404178d },
            { 78500.0d, 0.00399249d },
            { 79000.0d, 0.00394342d },
            { 79500.0d, 0.00389458d },
            { 80000.0d, 0.00384597d },
            { 80500.0d, 0.00379759d },
            { 81000.0d, 0.00374944d },
            { 81500.0d, 0.00370153d },
            { 82000.0d, 0.00365385d },
            { 82500.0d, 0.00360641d },
            { 83000.0d, 0.00355921d },
            { 83500.0d, 0.00351224d },
            { 84000.0d, 0.00346552d },
            { 84500.0d, 0.00341904d },
            { 85000.0d, 0.00337281d },
            { 85500.0d, 0.00332682d },
            { 86000.0d, 0.00328107d },
            { 86500.0d, 0.00323558d },
            { 87000.0d, 0.00319034d },
            { 87500.0d, 0.00314534d },
            { 88000.0d, 0.0031006d },
            { 88500.0d, 0.00305611d },
            { 89000.0d, 0.00301188d },
            { 89500.0d, 0.00296791d },
            { 90000.0d, 0.00292419d },
            { 90500.0d, 0.00288074d },
            { 91000.0d, 0.00283754d },
            { 91500.0d, 0.00279461d },
            { 92000.0d, 0.00275195d },
            { 92500.0d, 0.00270954d },
            { 93000.0d, 0.00266741d },
            { 93500.0d, 0.00262554d },
            { 94000.0d, 0.00258395d },
            { 94500.0d, 0.00254263d },
            { 95000.0d, 0.00250158d },
            { 95500.0d, 0.0024608d },
            { 96000.0d, 0.0024203d },
            { 96500.0d, 0.00238008d },
            { 97000.0d, 0.00234014d },
            { 97500.0d, 0.00230048d },
            { 98000.0d, 0.0022611d },
            { 98500.0d, 0.002222d },
            { 99000.0d, 0.00218319d },
            { 99500.0d, 0.00214466d },
            { 100000.0d, 0.00210643d },
            { 100500.0d, 0.00206848d },
            { 101000.0d, 0.00203082d },
            { 101500.0d, 0.00199346d },
            { 102000.0d, 0.00195639d },
            { 102500.0d, 0.00191962d },
            { 103000.0d, 0.00188314d },
            { 103500.0d, 0.00184696d },
            { 104000.0d, 0.00181108d },
            { 104500.0d, 0.00177551d },
            { 105000.0d, 0.00174023d },
            { 105500.0d, 0.00170526d },
            { 106000.0d, 0.0016706d },
            { 106500.0d, 0.00163624d },
            { 107000.0d, 0.0016022d },
            { 107500.0d, 0.00156846d },
            { 108000.0d, 0.00153504d },
            { 108500.0d, 0.00150193d },
            { 109000.0d, 0.00146913d },
            { 109500.0d, 0.00143666d },
            { 110000.0d, 0.0014045d },
            { 110500.0d, 0.00137266d },
            { 111000.0d, 0.00134114d },
            { 111500.0d, 0.00130994d },
            { 112000.0d, 0.00127907d },
            { 112500.0d, 0.00124853d },
            { 113000.0d, 0.00121831d },
            { 113500.0d, 0.00118842d },
            { 114000.0d, 0.00115886d },
            { 114500.0d, 0.00112964d },
            { 115000.0d, 0.00110074d },
            { 115500.0d, 0.00107219d },
            { 116000.0d, 0.00104397d },
            { 116500.0d, 0.00101609d },
            { 117000.0d, 0.000988544d },
            { 117500.0d, 0.000961344d },
            { 118000.0d, 0.000934487d },
            { 118500.0d, 0.000907974d },
            { 119000.0d, 0.000881808d },
            { 119500.0d, 0.000855989d },
            { 120000.0d, 0.00083052d },
            { 120500.0d, 0.000805402d },
            { 121000.0d, 0.000780636d },
            { 121500.0d, 0.000756224d },
            { 122000.0d, 0.000732167d },
            { 122500.0d, 0.000708468d },
            { 123000.0d, 0.000685128d },
            { 123500.0d, 0.000662148d },
            { 124000.0d, 0.00063953d },
            { 124500.0d, 0.000617276d },
            { 125000.0d, 0.000595386d },
            { 125500.0d, 0.000573864d },
            { 126000.0d, 0.000552709d },
            { 126500.0d, 0.000531925d },
            { 127000.0d, 0.000511512d },
            { 127500.0d, 0.000491472d },
            { 128000.0d, 0.000471807d },
            { 128500.0d, 0.000452518d },
            { 129000.0d, 0.000433607d },
            { 129500.0d, 0.000415075d },
            { 130000.0d, 0.000396925d },
            { 130500.0d, 0.000379157d },
            { 131000.0d, 0.000361774d },
            { 131500.0d, 0.000344776d },
            { 132000.0d, 0.000328166d },
            { 132500.0d, 0.000311945d },
            { 133000.0d, 0.000296115d },
            { 133500.0d, 0.000280677d },
            { 134000.0d, 0.000265634d },
            { 134500.0d, 0.000250986d },
            { 135000.0d, 0.000236735d },
            { 135500.0d, 0.000222883d },
            { 136000.0d, 0.000209431d },
            { 136500.0d, 0.000196382d },
            { 137000.0d, 0.000183736d },
            { 137500.0d, 0.000171496d },
            { 138000.0d, 0.000159663d },
            { 138500.0d, 0.000148238d },
            { 139000.0d, 0.000137224d },
            { 139500.0d, 0.000126622d },
            { 140000.0d, 0.000116433d },
            { 140500.0d, 0.000106659d },
            { 141000.0d, 0.0000973025d },
            { 141500.0d, 0.0000883642d },
            { 142000.0d, 0.000079846d },
            { 142500.0d, 0.0000717495d },
            { 143000.0d, 0.0000640764d },
            { 143500.0d, 0.0000568283d },
            { 144000.0d, 0.0000500069d },
            { 144500.0d, 0.0000436138d },
            { 145000.0d, 0.0000376507d },
            { 145500.0d, 0.0000321192d },
            { 146000.0d, 0.0000270209d },
            { 146500.0d, 0.0000223575d },
            { 147000.0d, 0.0000181307d },
            { 147500.0d, 0.000014342d },
            { 148000.0d, 0.000010993d },
            { 148500.0d, 0.00000808555d },
            { 149000.0d, 0.0000056211d },
            { 149500.0d, 0.00000360131d },
            { 150000.0d, 0.00000202776d },
            { 150500.0d, 0.000000902035d },
            { 151000.0d, 0.000000225655d },
            { 151500.0d, 0d },

        }; 
    }
}
    