using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum162 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum162";
        public override double halfLife { get; } = 3.57d;
        public override double atomicWeight { get; } = 161.95729d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99926d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium162() }, { 1.0d, new BetaParticle(1, 6525000.0) } } },
            { 0.00074d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium158() }, { 1.0d, new AlphaParticle(6029002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    