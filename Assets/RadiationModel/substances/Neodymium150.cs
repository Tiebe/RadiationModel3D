using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium150";
        public override double halfLife { get; } = 2.871680263687872e+26d;
        public override double atomicWeight { get; } = 149.9209d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium150() }, { 1.0d, new BetaParticle(-1, 1685650.00001) }, { 1.0d, new BetaParticle(-1, 1685650.00001) } } },

        };
    }
}
    