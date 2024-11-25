using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium125";
        public override double halfLife { get; } = 0.68d;
        public override double atomicWeight { get; } = 124.92126d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium125() }, { 1.0d, new BetaParticle(-1, 3532100.0) }, { 0.01455d, new GammaParticle(267880.0, 0.00463) }, { 0.013580000000000002d, new GammaParticle(294380.0, 0.00421) }, { 0.01843d, new GammaParticle(302960.0, 0.00409) }, { 0.006693d, new GammaParticle(361100.0, 0.00343) }, { 0.008245d, new GammaParticle(369230.0, 0.00336) }, { 0.02231d, new GammaParticle(389450.0, 0.00318) }, { 0.03104d, new GammaParticle(422910.0, 0.00293) }, { 0.4171d, new GammaParticle(436290.0, 0.00284) }, { 0.013580000000000002d, new GammaParticle(445320.0, 0.00278) }, { 0.003201d, new GammaParticle(538900.0, 0.0023) }, { 0.004947d, new GammaParticle(551460.0, 0.00225) }, { 0.0291d, new GammaParticle(687280.0, 0.0018) }, { 0.01164d, new GammaParticle(774460.0, 0.0016) }, { 0.032010000000000004d, new GammaParticle(792430.0, 0.00156) }, { 0.01746d, new GammaParticle(799000.0, 0.00155) }, { 0.06586299999999999d, new GammaParticle(859710.0, 0.00144) }, { 0.04656d, new GammaParticle(996780.0, 0.00124) }, { 0.03783d, new GammaParticle(1013970.0, 0.00122) }, { 0.24832d, new GammaParticle(1099480.0, 0.00113) }, { 0.021339999999999998d, new GammaParticle(1249750.0, 0.00099) }, { 0.004656d, new GammaParticle(1256700.0, 0.00099) }, { 0.00873d, new GammaParticle(1275150.0, 0.00097) }, { 0.01746d, new GammaParticle(1349900.0, 0.00092) }, { 0.026772d, new GammaParticle(1364640.0, 0.00091) }, { 0.01455d, new GammaParticle(1421670.0, 0.00087) }, { 0.028130000000000002d, new GammaParticle(1552880.0, 0.0008) }, { 0.08051d, new GammaParticle(1584830.0, 0.00078) }, { 0.12028d, new GammaParticle(1700960.0, 0.00073) }, { 0.009215d, new GammaParticle(1788380.0, 0.00069) }, { 0.0194d, new GammaParticle(1844430.0, 0.00067) }, { 0.01843d, new GammaParticle(1989500.0, 0.00062) }, { 0.01261d, new GammaParticle(2021160.0, 0.00061) }, { 0.024249999999999997d, new GammaParticle(2115580.0, 0.00059) }, { 0.03783d, new GammaParticle(2133250.0, 0.00058) }, { 0.21242999999999998d, new GammaParticle(2147190.0, 0.00058) }, { 0.032010000000000004d, new GammaParticle(2290260.0, 0.00054) }, { 0.01552d, new GammaParticle(2380240.0, 0.00052) }, { 0.007372d, new GammaParticle(2938700.0, 0.00042) } } },

        };
    }
}
    