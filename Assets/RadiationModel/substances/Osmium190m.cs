using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium190m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium190m";
        public override double halfLife { get; } = 591.6d;
        public override double atomicWeight { get; } = 189.96028d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium190() }, { 0.0008100000000000001d, new GammaParticle(38900.0, 0.03187) }, { 0.7020000000000001d, new GammaParticle(186720.0, 0.00664) }, { 0.9492d, new GammaParticle(361121.0, 0.00343) }, { 0.978d, new GammaParticle(502578.0, 0.00247) }, { 0.9863d, new GammaParticle(616342.0, 0.00201) }, { 0.31997348385464003d, new GammaParticle(10393.0, 0.1193) }, { 0.05663509869908277d, new GammaParticle(61486.0, 0.02016) }, { 0.09759624108061825d, new GammaParticle(63000.0, 0.01968) }, { 0.03265366646898358d, new GammaParticle(71496.0, 0.01734) }, { 0.04179669308029898d, new GammaParticle(72338.0, 0.01714) }, { 0.009143026611315401d, new GammaParticle(73364.0, 0.0169) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    