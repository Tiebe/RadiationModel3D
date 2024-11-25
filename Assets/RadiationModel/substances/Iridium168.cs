using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium168";
        public override double halfLife { get; } = 0.222d;
        public override double atomicWeight { get; } = 167.97996d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium164() }, { 1.0d, new AlphaParticle(7397002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    