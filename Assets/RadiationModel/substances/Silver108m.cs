using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver108m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver108m";
        public override double halfLife { get; } = 13821933576.8713d;
        public override double atomicWeight { get; } = 107.90607d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9129999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium108() }, { 1.0d, new BetaParticle(1, -1233150.0) }, { 0.905d, new GammaParticle(433937.0, 0.00286) }, { 0.898d, new GammaParticle(614276.0, 0.00202) }, { 0.9079999999999999d, new GammaParticle(722907.0, 0.00172) }, { 0.047086772922520004d, new GammaParticle(3053.0, 0.40611) }, { 0.18391643060452786d, new GammaParticle(21020.0, 0.05898) }, { 0.3474710572539729d, new GammaParticle(21177.0, 0.05855) }, { 0.09533182367649515d, new GammaParticle(23904.0, 0.05187) }, { 0.11153823370149932d, new GammaParticle(24070.0, 0.05151) }, { 0.016206410025004173d, new GammaParticle(24297.0, 0.05103) } } },
            { 0.087d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver108() }, { 2.04e-07d, new GammaParticle(30380.0, 0.04081) }, { 0.066d, new GammaParticle(79131.0, 0.01567) }, { 0.005085457882560001d, new GammaParticle(3218.0, 0.38528) }, { 0.004803156165743288d, new GammaParticle(21990.0, 0.05638) }, { 0.00905401727755568d, new GammaParticle(22163.0, 0.05594) }, { 0.0025082192135443197d, new GammaParticle(25030.0, 0.04953) }, { 0.0029446493567010313d, new GammaParticle(25211.0, 0.04918) }, { 0.0004364301431567117d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    