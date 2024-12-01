using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium226";
        public override double halfLife { get; } = 50491081559.3472d;
        public override double atomicWeight { get; } = 226.02541d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon222()), new(1.0d, new AlphaParticle(5892602.09)), new(6e-10d, new GammaParticle(34810.0, 0.03562)), new(0.03565d, new GammaParticle(186211.0, 0.00666)), new(5e-05d, new GammaParticle(262270.0, 0.00473)), new(2.9999999999999997e-06d, new GammaParticle(414600.0, 0.00299)), new(1.9e-06d, new GammaParticle(449370.0, 0.00276)), new(4.9e-06d, new GammaParticle(600660.0, 0.00206)), new(0.00782875307941856d, new GammaParticle(14088.0, 0.08801)), new(0.0019261177670065082d, new GammaParticle(81070.0, 0.01529)), new(0.00317736352195069d, new GammaParticle(83789.0, 0.0148)), new(0.0011018880055703043d, new GammaParticle(94878.0, 0.01307)), new(0.0014544921673528017d, new GammaParticle(96054.0, 0.01291)), new(0.00035260416178249735d, new GammaParticle(97530.0, 0.01271)) } },
            { 3.2e-11d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    