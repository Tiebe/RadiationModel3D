using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium254m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium254m";
        public override double halfLife { get; } = 0.265d;
        public override double atomicWeight { get; } = 254.09235d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nobelium254() } } },
            { 0.0002d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.0001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium250() }, { 1.0d, new AlphaParticle(10544002.09) } } },

        };
    }
}
    