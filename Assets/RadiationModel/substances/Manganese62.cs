using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese62 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese62";
        public override double halfLife { get; } = 0.092d;
        public override double atomicWeight { get; } = 61.94791d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron62() }, { 1.0d, new BetaParticle(-1, 5177050.0) }, { 0.0057599999999999995d, new GammaParticle(294300.0, 0.00421) }, { 0.00192d, new GammaParticle(301000.0, 0.00412) }, { 0.01536d, new GammaParticle(515200.0, 0.00241) }, { 0.04224d, new GammaParticle(673300.0, 0.00184) }, { 0.051840000000000004d, new GammaParticle(674800.0, 0.00184) }, { 0.0144d, new GammaParticle(832400.0, 0.00149) }, { 0.0144d, new GammaParticle(839300.0, 0.00148) }, { 0.96d, new GammaParticle(877300.0, 0.00141) }, { 0.20256d, new GammaParticle(941800.0, 0.00132) }, { 0.336d, new GammaParticle(1139800.0, 0.00109) }, { 0.01248d, new GammaParticle(1183800.0, 0.00105) }, { 0.03648d, new GammaParticle(1201100.0, 0.00103) }, { 0.36479999999999996d, new GammaParticle(1299200.0, 0.00095) }, { 0.15648d, new GammaParticle(1457100.0, 0.00085) }, { 0.00864d, new GammaParticle(1485200.0, 0.00083) }, { 0.011519999999999999d, new GammaParticle(1537200.0, 0.00081) }, { 0.0528d, new GammaParticle(1616400.0, 0.00077) }, { 0.30624d, new GammaParticle(1814000.0, 0.00068) }, { 0.0048d, new GammaParticle(1874000.0, 0.00066) }, { 0.0384d, new GammaParticle(2017000.0, 0.00061) }, { 0.05088d, new GammaParticle(2756000.0, 0.00045) }, { 0.0096d, new GammaParticle(3172300.0, 0.00039) }, { 2.16799488e-06d, new GammaParticle(728.0, 1.70308) }, { 2.472822684927275e-05d, new GammaParticle(6391.0, 0.194) }, { 4.842026013172655e-05d, new GammaParticle(6404.0, 0.1936) }, { 1.0006713019000703e-05d, new GammaParticle(7082.0, 0.17507) }, { 1.0006713019000703e-05d, new GammaParticle(7082.0, 0.17507) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    