using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium103";
        public override double halfLife { get; } = 3390940.8d;
        public override double atomicWeight { get; } = 102.90631d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium103() }, { 1.0d, new BetaParticle(-1, 382250.0) }, { 0.0006916d, new GammaParticle(39760.0, 0.03118) }, { 5.1869999999999996e-05d, new GammaParticle(42630.0, 0.02908) }, { 0.0044317d, new GammaParticle(53286.0, 0.02327) }, { 4.3679999999999995e-06d, new GammaParticle(62410.0, 0.01987) }, { 3.185e-05d, new GammaParticle(113191.0, 0.01095) }, { 7.371e-05d, new GammaParticle(114870.0, 0.01079) }, { 0.00014287d, new GammaParticle(241875.0, 0.00513) }, { 9.1e-06d, new GammaParticle(292700.0, 0.00424) }, { 0.0028847d, new GammaParticle(294964.0, 0.0042) }, { 9.1e-05d, new GammaParticle(317720.0, 0.0039) }, { 8.645e-05d, new GammaParticle(357382.0, 0.00347) }, { 0.0033943000000000003d, new GammaParticle(443810.0, 0.00279) }, { 0.91d, new GammaParticle(497085.0, 0.00249) }, { 6.188e-05d, new GammaParticle(514365.0, 0.00241) }, { 0.0084084d, new GammaParticle(557057.0, 0.00223) }, { 2.0929999999999998e-05d, new GammaParticle(567693.0, 0.00218) }, { 0.057603d, new GammaParticle(610333.0, 0.00203) }, { 0.0010465000000000001d, new GammaParticle(612094.0, 0.00203) }, { 2.1839999999999998e-06d, new GammaParticle(651690.0, 0.0019) }, { 0.04170564389751258d, new GammaParticle(2892.0, 0.42871) }, { 0.025773737361456394d, new GammaParticle(20073.0, 0.06177) }, { 0.048795413406770904d, new GammaParticle(20215.0, 0.06133) }, { 0.013251053206841078d, new GammaParticle(22806.0, 0.05436) }, { 0.015450728039176695d, new GammaParticle(22957.0, 0.05401) }, { 0.002199674832335619d, new GammaParticle(23170.0, 0.05351) } } },

        };
    }
}
    