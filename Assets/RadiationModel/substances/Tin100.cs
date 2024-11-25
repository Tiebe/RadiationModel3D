using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin100 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin100";
        public override double halfLife { get; } = 1.18d;
        public override double atomicWeight { get; } = 99.93865d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium100() }, { 1.0d, new BetaParticle(1, 8522300.0) }, { 0.63d, new GammaParticle(95000.0, 0.01305) }, { 0.92d, new GammaParticle(141000.0, 0.00879) }, { 0.98d, new GammaParticle(436000.0, 0.00284) }, { 0.64d, new GammaParticle(1297000.0, 0.00096) }, { 0.36d, new GammaParticle(2048000.0, 0.00061) }, { 1.8d, new GammaParticle(511000.0, 0.00243) }, { 0.041855895347903994d, new GammaParticle(3571.0, 0.3472) }, { 0.13889156521004964d, new GammaParticle(24001.0, 0.05166) }, { 0.2605845501126635d, new GammaParticle(24209.0, 0.05121) }, { 0.0731141999304932d, new GammaParticle(27367.0, 0.0453) }, { 0.08700589791728691d, new GammaParticle(27581.0, 0.04495) }, { 0.013891697986793707d, new GammaParticle(27858.0, 0.04451) } } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium99() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    