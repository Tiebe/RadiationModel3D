using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium260";
        public override double halfLife { get; } = 1.52d;
        public override double atomicWeight { get; } = 260.11129d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.904d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lawrencium256() }, { 1.0d, new AlphaParticle(10517002.09) } } },
            { 0.096d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.025d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rutherfordium260() } } },

        };
    }
}
    