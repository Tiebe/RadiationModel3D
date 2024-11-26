using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum187 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum187";
        public override double halfLife { get; } = 283.0d;
        public override double atomicWeight { get; } = 186.96039d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten187()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.068d, new GammaParticle(77240.0, 0.01605)), new(0.031d, new GammaParticle(123900.0, 0.01001)), new(0.08800000000000001d, new GammaParticle(148800.0, 0.00833)), new(0.126d, new GammaParticle(201300.0, 0.00616)), new(0.61d, new GammaParticle(273000.0, 0.00454)), new(0.021d, new GammaParticle(350500.0, 0.00354)), new(0.2315448727875d, new GammaParticle(9740.0, 0.12729)), new(0.19158718720877946d, new GammaParticle(57983.0, 0.02138)), new(0.3327899725704003d, new GammaParticle(59320.0, 0.0209)), new(0.11030853910582432d, new GammaParticle(67335.0, 0.01841)), new(0.1405330788208202d, new GammaParticle(68117.0, 0.0182)), new(0.030224539714995863d, new GammaParticle(69068.0, 0.01795)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    