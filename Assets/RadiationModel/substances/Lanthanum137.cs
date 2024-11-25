using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum137 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum137";
        public override double halfLife { get; } = 1893415558475.52d;
        public override double atomicWeight { get; } = 136.90645d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium137() }, { 0.09579064000000001d, new GammaParticle(4966.0, 0.24967) }, { 0.21485442295159235d, new GammaParticle(31816.0, 0.03897) }, { 0.3958261292402217d, new GammaParticle(32193.0, 0.03851) }, { 0.11642927141228913d, new GammaParticle(36482.0, 0.03399) }, { 0.14576944780818601d, new GammaParticle(36827.0, 0.03367) }, { 0.02934017639589686d, new GammaParticle(37255.0, 0.03328) } } },

        };
    }
}
    