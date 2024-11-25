using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur29 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur29";
        public override double halfLife { get; } = 0.188d;
        public override double atomicWeight { get; } = 28.99668d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon29() }, { 1.0d, new BetaParticle(1, 9400540.75) }, { 0.0108d, new GammaParticle(468790.0, 0.00264) }, { 0.015600000000000001d, new GammaParticle(570360.0, 0.00217) }, { 0.0322d, new GammaParticle(1039150.0, 0.00119) }, { 0.0053d, new GammaParticle(1151990.0, 0.00108) }, { 0.45d, new GammaParticle(1383550.0, 0.0009) }, { 0.0002d, new GammaParticle(1657800.0, 0.00075) }, { 0.0167d, new GammaParticle(1722350.0, 0.00072) }, { 0.0046d, new GammaParticle(1848200.0, 0.00067) }, { 0.179d, new GammaParticle(1953910.0, 0.00063) }, { 0.0026d, new GammaParticle(2126590.0, 0.00058) }, { 0.0086d, new GammaParticle(2187100.0, 0.00057) }, { 0.226d, new GammaParticle(2422700.0, 0.00051) }, { 0.017d, new GammaParticle(2531400.0, 0.00049) }, { 0.0022d, new GammaParticle(2696950.0, 0.00046) }, { 0.0248d, new GammaParticle(3000190.0, 0.00041) }, { 0.0007000000000000001d, new GammaParticle(3105900.0, 0.0004) }, { 0.0304d, new GammaParticle(3339090.0, 0.00037) }, { 0.036000000000000004d, new GammaParticle(3424900.0, 0.00036) }, { 0.091d, new GammaParticle(3570550.0, 0.00035) }, { 0.0023d, new GammaParticle(3909450.0, 0.00032) }, { 0.017d, new GammaParticle(4954100.0, 0.00025) }, { 0.045d, new GammaParticle(5956300.0, 0.00021) }, { 0.079d, new GammaParticle(6425090.0, 0.00019) }, { 0.022000000000000002d, new GammaParticle(6995450.0, 0.00018) }, { 2.01224d, new GammaParticle(511000.0, 0.00243) }, { 2.3456761171200002e-07d, new GammaParticle(149.0, 8.32109) }, { 3.452535921775152e-06d, new GammaParticle(2013.0, 0.61592) }, { 6.839413474198003e-06d, new GammaParticle(2014.0, 0.61561) }, { 4.425538240268456e-07d, new GammaParticle(2138.0, 0.57991) }, { 4.425538240268456e-07d, new GammaParticle(2138.0, 0.57991) } } },
            { 0.47d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon28() }, { 1.0d, new ProtonParticle() }, { 0.11599999999999999d, new GammaParticle(1778969.0, 0.0007) }, { 0.0016d, new GammaParticle(2838670.0, 0.00044) }, { 1.07516717e-09d, new GammaParticle(118.0, 10.50714) }, { 1.6310404208394803e-08d, new GammaParticle(1740.0, 0.71255) }, { 3.2381187628339894e-08d, new GammaParticle(1740.0, 0.71255) }, { 1.4120561632653063e-09d, new GammaParticle(1836.0, 0.6753) }, { 1.4120561632653063e-09d, new GammaParticle(1836.0, 0.6753) } } },

        };
    }
}
    