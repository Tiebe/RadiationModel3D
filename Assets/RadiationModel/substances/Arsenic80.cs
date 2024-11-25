using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic80 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic80";
        public override double halfLife { get; } = 15.2d;
        public override double atomicWeight { get; } = 79.92247d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium80() }, { 1.0d, new BetaParticle(-1, 2772250.0) }, { 0.42d, new GammaParticle(666200.0, 0.00186) }, { 0.00966d, new GammaParticle(782600.0, 0.00158) }, { 0.00252d, new GammaParticle(811500.0, 0.00153) }, { 0.007980000000000001d, new GammaParticle(861600.0, 0.00144) }, { 0.00126d, new GammaParticle(1064700.0, 0.00116) }, { 0.042839999999999996d, new GammaParticle(1207100.0, 0.00103) }, { 0.01008d, new GammaParticle(1294200.0, 0.00096) }, { 0.00084d, new GammaParticle(1415900.0, 0.00088) }, { 0.011200000000000002d, new GammaParticle(1448800.0, 0.00086) }, { 0.07518d, new GammaParticle(1645200.0, 0.00075) }, { 0.01134d, new GammaParticle(1847700.0, 0.00067) }, { 0.00462d, new GammaParticle(1959700.0, 0.00063) }, { 0.00084d, new GammaParticle(2156900.0, 0.00057) }, { 0.00882d, new GammaParticle(2357800.0, 0.00053) }, { 0.00168d, new GammaParticle(2514000.0, 0.00049) }, { 0.00294d, new GammaParticle(2774200.0, 0.00045) }, { 0.00252d, new GammaParticle(2836200.0, 0.00044) }, { 0.00084d, new GammaParticle(2940300.0, 0.00042) }, { 0.00084d, new GammaParticle(3024000.0, 0.00041) }, { 0.00042d, new GammaParticle(3060800.0, 0.00041) } } },

        };
    }
}
    