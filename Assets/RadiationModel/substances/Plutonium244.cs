using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium244";
        public override double halfLife { get; } = 2565578081734329.5d;
        public override double atomicWeight { get; } = 244.0642d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9987699999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium240() }, { 1.0d, new AlphaParticle(5687502.09) }, { 0.00029d, new GammaParticle(44000.0, 0.02818) }, { 0.056939000000000003d, new GammaParticle(16678.0, 0.07434) } } },
            { 0.00123d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    