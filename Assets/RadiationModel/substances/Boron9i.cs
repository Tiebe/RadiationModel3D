using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron9i : RadioactiveSubstance
    {
        public override string name { get; } = "Boron9i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 9.02906d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.46d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lithium5() }, { 1.0d, new AlphaParticle(13988002.09) } } },
            { 0.44d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium8() }, { 1.0d, new ProtonParticle() } } },
            { 0.0409d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron9() } } },

        };
    }
}
    