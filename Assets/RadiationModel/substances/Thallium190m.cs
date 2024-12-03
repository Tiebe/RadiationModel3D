using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium190m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium190m";
        public override double halfLife { get; } = 216.0d;
        public override double atomicWeight { get; } = 189.97392d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold190()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.002002d, new GammaParticle(142700.0, 0.00869)), new(0.0455d, new GammaParticle(196800.0, 0.0063)), new(0.03458d, new GammaParticle(240100.0, 0.00516)), new(0.01547d, new GammaParticle(257000.0, 0.00482)), new(0.000273d, new GammaParticle(292600.0, 0.00424)), new(0.1547d, new GammaParticle(305300.0, 0.00406)), new(0.01365d, new GammaParticle(313700.0, 0.00395)), new(0.01274d, new GammaParticle(346500.0, 0.00358)), new(0.04459d, new GammaParticle(370300.0, 0.00335)), new(0.00182d, new GammaParticle(390100.0, 0.00318)), new(0.00182d, new GammaParticle(390100.0, 0.00318)), new(0.0025480000000000004d, new GammaParticle(403800.0, 0.00307)), new(0.91d, new GammaParticle(416400.0, 0.00298)), new(0.0027300000000000002d, new GammaParticle(428100.0, 0.0029)), new(0.0091d, new GammaParticle(437600.0, 0.00283)), new(0.010009999999999998d, new GammaParticle(445100.0, 0.00279)), new(0.0091d, new GammaParticle(458700.0, 0.0027)), new(0.0182d, new GammaParticle(466100.0, 0.00266)), new(0.01183d, new GammaParticle(478300.0, 0.00259)), new(0.004277d, new GammaParticle(492100.0, 0.00252)), new(0.0053690000000000005d, new GammaParticle(506000.0, 0.00245)), new(0.001638d, new GammaParticle(514500.0, 0.00241)), new(0.00637d, new GammaParticle(516800.0, 0.0024)), new(0.001638d, new GammaParticle(529700.0, 0.00234)), new(0.006825d, new GammaParticle(534700.0, 0.00232)), new(0.056420000000000005d, new GammaParticle(543900.0, 0.00228)), new(0.0637d, new GammaParticle(557000.0, 0.00223)), new(0.0027300000000000002d, new GammaParticle(569900.0, 0.00218)), new(0.00364d, new GammaParticle(592600.0, 0.00209)), new(0.01547d, new GammaParticle(604300.0, 0.00205)), new(0.04277d, new GammaParticle(615300.0, 0.00202)), new(0.00091d, new GammaParticle(620400.0, 0.002)), new(0.8190000000000001d, new GammaParticle(625400.0, 0.00198)), new(0.006643d, new GammaParticle(658700.0, 0.00188)), new(0.07098d, new GammaParticle(683500.0, 0.00181)), new(0.0054600000000000004d, new GammaParticle(685800.0, 0.00181)), new(0.04732d, new GammaParticle(692100.0, 0.00179)), new(0.37310000000000004d, new GammaParticle(731100.0, 0.0017)), new(0.003094d, new GammaParticle(736900.0, 0.00168)), new(0.010920000000000001d, new GammaParticle(751100.0, 0.00165)), new(0.014833d, new GammaParticle(800100.0, 0.00155)), new(0.007189d, new GammaParticle(808000.0, 0.00153)), new(0.2366d, new GammaParticle(839700.0, 0.00148)), new(0.004368d, new GammaParticle(933400.0, 0.00133)), new(0.012284999999999999d, new GammaParticle(1030900.0, 0.0012)), new(0.043680000000000004d, new GammaParticle(1099900.0, 0.00113)), new(0.007917d, new GammaParticle(1121100.0, 0.00111)), new(0.03458d, new GammaParticle(1142500.0, 0.00109)), new(0.006279d, new GammaParticle(1155000.0, 0.00107)), new(0.004641d, new GammaParticle(1159700.0, 0.00107)), new(0.02093d, new GammaParticle(1194700.0, 0.00104)), new(0.01365d, new GammaParticle(1240900.0, 0.001)), new(0.01274d, new GammaParticle(1276700.0, 0.00097)), new(0.001456d, new GammaParticle(1300800.0, 0.00095)), new(0.01547d, new GammaParticle(1323400.0, 0.00094)), new(0.00728d, new GammaParticle(1348000.0, 0.00092)), new(0.0012740000000000002d, new GammaParticle(1434700.0, 0.00086)), new(0.003458d, new GammaParticle(1468100.0, 0.00084)), new(0.011102d, new GammaParticle(1558800.0, 0.0008)), new(0.0091d, new GammaParticle(1558900.0, 0.0008)), new(0.001911d, new GammaParticle(1571200.0, 0.00079)), new(0.7757999999999999d, new GammaParticle(511000.0, 0.00243)), new(0.1d, new GammaParticle(11777.0, 0.10528)), new(0.08d, new GammaParticle(68894.0, 0.018)), new(0.13d, new GammaParticle(70820.0, 0.01751)), new(0.05d, new GammaParticle(80316.0, 0.01544)), new(0.06d, new GammaParticle(81285.0, 0.01525)), new(0.013000000000000001d, new GammaParticle(82477.0, 0.01503)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    