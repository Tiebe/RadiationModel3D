using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine78m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine78m";
        public override double halfLife { get; } = 0.00012d;
        public override double atomicWeight { get; } = 77.92134d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine78() }, { 0.385d, new GammaParticle(32300.0, 0.03839) }, { 0.77d, new GammaParticle(148600.0, 0.00834) }, { 0.020348427199999998d, new GammaParticle(1535.0, 0.80771) }, { 0.14896166169681135d, new GammaParticle(11879.0, 0.10437) }, { 0.287515270597976d, new GammaParticle(11925.0, 0.10397) }, { 0.06819445572336864d, new GammaParticle(13345.0, 0.09291) }, { 0.0734590677052127d, new GammaParticle(13377.0, 0.09268) }, { 0.00526461198184406d, new GammaParticle(13469.0, 0.09205) } } },

        };
    }
}
    