using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth218 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth218";
        public override double halfLife { get; } = 33.0d;
        public override double atomicWeight { get; } = 218.01419d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium218() }, { 1.0d, new BetaParticle(-1, 2429650.00001) }, { 0.0016d, new GammaParticle(174500.0, 0.00711) }, { 0.0008d, new GammaParticle(176600.0, 0.00702) }, { 0.392d, new GammaParticle(263000.0, 0.00471) }, { 0.0016d, new GammaParticle(287100.0, 0.00432) }, { 0.8d, new GammaParticle(385700.0, 0.00321) }, { 0.048d, new GammaParticle(418300.0, 0.00296) }, { 0.856d, new GammaParticle(425500.0, 0.00291) }, { 0.032d, new GammaParticle(437000.0, 0.00284) }, { 0.048d, new GammaParticle(463500.0, 0.00267) }, { 0.968d, new GammaParticle(509700.0, 0.00243) }, { 0.08d, new GammaParticle(537800.0, 0.00231) }, { 0.0672d, new GammaParticle(702900.0, 0.00176) }, { 0.061232379686399996d, new GammaParticle(13292.0, 0.09328) }, { 0.032003468947155264d, new GammaParticle(76862.0, 0.01613) }, { 0.05329470265970901d, new GammaParticle(79290.0, 0.01564) }, { 0.01834789046005776d, new GammaParticle(89837.0, 0.0138) }, { 0.024054084393135725d, new GammaParticle(90941.0, 0.01363) }, { 0.005706193933077964d, new GammaParticle(92315.0, 0.01343) } } },

        };
    }
}
    