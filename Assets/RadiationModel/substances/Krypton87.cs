using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton87 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton87";
        public override double halfLife { get; } = 4578.0d;
        public override double atomicWeight { get; } = 86.91335d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium87() }, { 1.0d, new BetaParticle(-1, 1944136.0) }, { 0.0004464d, new GammaParticle(129400.0, 0.00958) }, { 0.496d, new GammaParticle(402588.0, 0.00308) }, { 0.0007936d, new GammaParticle(510780.0, 0.00243) }, { 0.0003472d, new GammaParticle(582320.0, 0.00213) }, { 0.0188976d, new GammaParticle(673830.0, 0.00184) }, { 0.0016367999999999999d, new GammaParticle(814250.0, 0.00152) }, { 0.0077376d, new GammaParticle(836380.0, 0.00148) }, { 0.073408d, new GammaParticle(845440.0, 0.00147) }, { 0.00045631999999999997d, new GammaParticle(894020.0, 0.00139) }, { 0.00026288d, new GammaParticle(901500.0, 0.00138) }, { 0.0012896d, new GammaParticle(946690.0, 0.00131) }, { 0.00056048d, new GammaParticle(976140.0, 0.00127) }, { 0.00026784d, new GammaParticle(1063200.0, 0.00117) }, { 0.011060799999999999d, new GammaParticle(1175410.0, 0.00105) }, { 0.0063488d, new GammaParticle(1338000.0, 0.00093) }, { 0.0028768d, new GammaParticle(1382550.0, 0.0009) }, { 0.0011904d, new GammaParticle(1389870.0, 0.00089) }, { 0.000496d, new GammaParticle(1461300.0, 0.00085) }, { 0.0035712d, new GammaParticle(1531200.0, 0.00081) }, { 0.0012896d, new GammaParticle(1578030.0, 0.00079) }, { 0.0011408d, new GammaParticle(1611180.0, 0.00077) }, { 0.0203856d, new GammaParticle(1740510.0, 0.00071) }, { 0.0013888d, new GammaParticle(1842610.0, 0.00067) }, { 0.0288176d, new GammaParticle(2011880.0, 0.00062) }, { 0.0009424d, new GammaParticle(2378500.0, 0.00052) }, { 0.0022816d, new GammaParticle(2408460.0, 0.00051) }, { 0.092256d, new GammaParticle(2554750.0, 0.00049) }, { 0.03968d, new GammaParticle(2558080.0, 0.00048) }, { 0.00023312d, new GammaParticle(2652480.0, 0.00047) }, { 0.0032240000000000003d, new GammaParticle(2811360.0, 0.00044) }, { 0.0006944d, new GammaParticle(2961200.0, 0.00042) }, { 0.0008035200000000001d, new GammaParticle(3055100.0, 0.00041) }, { 0.004464d, new GammaParticle(3308500.0, 0.00037) }, { 0.0001488d, new GammaParticle(3704600.0, 0.00033) }, { 5.2816113599999996e-05d, new GammaParticle(1767.0, 0.70166) }, { 0.0003529292693011437d, new GammaParticle(13336.0, 0.09297) }, { 0.0006793633672784287d, new GammaParticle(13396.0, 0.09255) }, { 0.0001653888202692003d, new GammaParticle(15021.0, 0.08254) }, { 0.00018457392342042755d, new GammaParticle(15070.0, 0.08227) }, { 1.9185103151227235e-05d, new GammaParticle(15187.0, 0.08164) } } },

        };
    }
}
    