using System;
using System.Collections.Generic;
using System.Text;

//https://github.com/dart-lang/sdk/blob/master/pkg/front_end/lib/src/base/timestamped_data.dart

namespace Dart2CSharpTranspiler.Parser
{
    public class TimestampedData<E>
    {
        /**
         * The modification time of the source from which the data was created.
         */
        public readonly int modificationTime;

        /**
         * The data that was created from the source.
         */
        public readonly E data;

        /**
         * Initialize a newly created holder to associate the given [data] with the
         * given [modificationTime].
         */
        public TimestampedData(int modificationTime, E data)
        {
            this.modificationTime = modificationTime;
            this.data = data;
        }
    }
}
