using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium115m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium115m";
        public override double halfLife { get; } = 50.0d;
        public override double atomicWeight { get; } = 114.91375d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.92d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver115() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 0.092d, new GammaParticle(749000.0, 0.00166) } } },
            { 0.08d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium115() }, { 0.0032d, new GammaParticle(89300.0, 0.01388) }, { 0.0036523040000000003d, new GammaParticle(3053.0, 0.40611) }, { 0.008444541646696257d, new GammaParticle(21020.0, 0.05898) }, { 0.01595416899054649d, new GammaParticle(21177.0, 0.05855) }, { 0.00437717039551902d, new GammaParticle(23904.0, 0.05187) }, { 0.005121289362757253d, new GammaParticle(24070.0, 0.05151) }, { 0.0007441189672382334d, new GammaParticle(24297.0, 0.05103) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    