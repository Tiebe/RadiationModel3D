using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine134m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine134m";
        public override double halfLife { get; } = 211.2d;
        public override double atomicWeight { get; } = 133.91012d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.977d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine134() }, { 0.10800000000000001d, new GammaParticle(44400.0, 0.02792) }, { 0.79d, new GammaParticle(272100.0, 0.00456) }, { 0.00475d, new GammaParticle(316300.0, 0.00392) }, { 0.086d, new GammaParticle(4335.0, 0.28601) }, { 0.21899999999999997d, new GammaParticle(28318.0, 0.04378) }, { 0.406d, new GammaParticle(28613.0, 0.04333) }, { 0.11699999999999999d, new GammaParticle(32395.0, 0.03827) }, { 0.14300000000000002d, new GammaParticle(32680.0, 0.03794) }, { 0.0264d, new GammaParticle(33040.0, 0.03753) } } },
            { 0.023d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon134() }, { 1.0d, new BetaParticle(-1, 2199417.0) }, { 0.016d, new GammaParticle(234300.0, 0.00529) }, { 0.023d, new GammaParticle(847000.0, 0.00146) }, { 0.023d, new GammaParticle(885000.0, 0.0014) }, { 0.0005989086617d, new GammaParticle(4540.0, 0.27309) }, { 0.0012022125730804028d, new GammaParticle(29458.0, 0.04209) }, { 0.0022271444480926324d, new GammaParticle(29778.0, 0.04164) }, { 0.0006456402741318489d, new GammaParticle(33726.0, 0.03676) }, { 0.0007980113788269652d, new GammaParticle(34030.0, 0.03643) }, { 0.00015237110469511634d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    