using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony124m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony124m";
        public override double halfLife { get; } = 93.0d;
        public override double atomicWeight { get; } = 123.90595d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony124() }, { 3.43e-05d, new GammaParticle(10860.0, 0.11417) }, { 0.049117737200000004d, new GammaParticle(3941.0, 0.3146) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium124() }, { 1.0d, new BetaParticle(-1, 1457950.0) }, { 0.25d, new GammaParticle(498400.0, 0.00249) }, { 0.25d, new GammaParticle(602720.0, 0.00206) }, { 0.25d, new GammaParticle(645820.0, 0.00192) }, { 0.005d, new GammaParticle(1101000.0, 0.00113) }, { 0.000334788296259d, new GammaParticle(4135.0, 0.29984) }, { 0.000918444717446314d, new GammaParticle(27202.0, 0.04558) }, { 0.0017103253583730241d, new GammaParticle(27473.0, 0.04513) }, { 0.0004894653238953672d, new GammaParticle(31093.0, 0.03988) }, { 0.000595679299180662d, new GammaParticle(31359.0, 0.03954) }, { 0.00010621397528529468d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    