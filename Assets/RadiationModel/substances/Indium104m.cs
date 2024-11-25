using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium104m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium104m";
        public override double halfLife { get; } = 15.7d;
        public override double atomicWeight { get; } = 103.91831d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium104() }, { 0.0126d, new GammaParticle(93500.0, 0.01326) }, { 0.04846298688d, new GammaParticle(3571.0, 0.3472) }, { 0.13163689968661207d, new GammaParticle(24001.0, 0.05166) }, { 0.24697354537825902d, new GammaParticle(24209.0, 0.05121) }, { 0.0692952562480075d, new GammaParticle(27367.0, 0.0453) }, { 0.08246135493512892d, new GammaParticle(27581.0, 0.04495) }, { 0.013166098687121425d, new GammaParticle(27858.0, 0.04451) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver104() }, { 1.0d, new BetaParticle(1, 4513000.0) } } },

        };
    }
}
    