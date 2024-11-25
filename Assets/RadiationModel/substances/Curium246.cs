using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium246";
        public override double halfLife { get; } = 148506893636.42996d;
        public override double atomicWeight { get; } = 246.06722d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9997385d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium242() }, { 1.0d, new AlphaParticle(6497002.09) }, { 0.000279d, new GammaParticle(44545.0, 0.02783) }, { 0.078929937d, new GammaParticle(17604.0, 0.07043) } } },
            { 0.0002615d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    