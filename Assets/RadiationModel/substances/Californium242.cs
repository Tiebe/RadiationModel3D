using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium242";
        public override double halfLife { get; } = 210.0d;
        public override double atomicWeight { get; } = 242.06375d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.61d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium238() }, { 1.0d, new AlphaParticle(8539002.09) } } },
            { 0.39d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium242() }, { 1.0d, new BetaParticle(1, 2291650.00001) } } },
            { 0.00014000000000000001d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    