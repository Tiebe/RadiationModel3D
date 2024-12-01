using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium218";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 218.00713d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon214()), new(1.0d, new AlphaParticle(9563002.09)), new(0.00121d, new GammaParticle(695000.0, 0.00178)), new(6.903236824e-06d, new GammaParticle(14088.0, 0.08801)), new(4.278528001319789e-06d, new GammaParticle(81070.0, 0.01529)), new(7.057947874166592e-06d, new GammaParticle(83789.0, 0.0148)), new(2.447648200389105e-06d, new GammaParticle(94878.0, 0.01307)), new(3.230895624513619e-06d, new GammaParticle(96054.0, 0.01291)), new(7.832474241245136e-07d, new GammaParticle(97530.0, 0.01271)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    