using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium179";
        public override double halfLife { get; } = 79.0d;
        public override double atomicWeight { get; } = 178.95912d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium179() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.07275000000000001d, new GammaParticle(45200.0, 0.02743) }, { 0.075d, new GammaParticle(86300.0, 0.01437) }, { 0.10125d, new GammaParticle(97500.0, 0.01272) }, { 0.05775d, new GammaParticle(100200.0, 0.01237) }, { 0.023250000000000003d, new GammaParticle(127700.0, 0.00971) }, { 0.03d, new GammaParticle(220000.0, 0.00564) }, { 0.398036814714d, new GammaParticle(10393.0, 0.1193) }, { 0.055701812257136496d, new GammaParticle(61486.0, 0.02016) }, { 0.09598795839589264d, new GammaParticle(63000.0, 0.01968) }, { 0.03211556863044601d, new GammaParticle(71496.0, 0.01734) }, { 0.0411079278469709d, new GammaParticle(72338.0, 0.01714) }, { 0.008992359216524883d, new GammaParticle(73364.0, 0.0169) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    