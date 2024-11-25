using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine192m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine192m";
        public override double halfLife { get; } = 0.088d;
        public override double atomicWeight { get; } = 192.00314d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth188() }, { 1.0d, new AlphaParticle(8718002.09) } } },

        };
    }
}
    